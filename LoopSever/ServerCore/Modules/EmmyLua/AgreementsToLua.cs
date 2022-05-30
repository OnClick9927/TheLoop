﻿using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Utils;
using IFramework;

namespace LoopSever.ServerCore.Modules.EmmyLua
{
    public class AgreementsToLua
    {
        private static string _outPutPathFileName = "";

        private static string OutPutPathFileName
        {
            get
            {
                if (_outPutPathFileName == "")
                {
                    var rootDir = Directory.GetCurrentDirectory().CombinePath("EmmyLua");
                    FileUtils.CreateDir(rootDir);
                    _outPutPathFileName = rootDir.CombinePath("NetEventDefine.lua.txt");
                }
                return _outPutPathFileName;
            }
        }
        static string left = "{";
        static string right = "}";
        public static void Build()
        {
            var responseTypes = typeof(IResponse).GetSubTypesInAssemblys().ToList();
            var requestTypes = typeof(IRequest).GetSubTypesInAssemblys().ToList();
            List<Type> types = new List<Type>();
            List<Type> enumTypes = new List<Type>();

            types.AddRange(responseTypes);
            types.AddRange(requestTypes);
            string result = BuildOther(BuidRequestAndResponse(types), types, enumTypes);
            result = BuildErrCode(BuildEnum(result, enumTypes));

            File.WriteAllText(OutPutPathFileName, result);
            Log.L("---------------EmmyLua 协议生成完毕----------------------------");
        }

        private static string BuildErrCode(string result)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                   .SelectMany(item => item.GetTypes())
                   .Where(t => t.IsDefined(typeof(NetworkErrCodeDefine), false)).ToList();
            result += "\nNetEventDefine.ErrorCodes = {\n";
            foreach (var type in types)
            {
                string name = type.Name;
                result += $"\t{name} = {left}\n";
                var _type = type;
                while (_type != typeof(Object))
                {
                    var fields = _type.GetFields();
                    foreach (var field in fields)
                    {
                        string _name = field.Name;
                        object value = field.GetValue(null);
                        result += $"\t\t{_name} = {value},\n";
                    }

                    _type = _type.BaseType;
                }
                result += $"\t{right},\n";

            }
            result += "}\n";
            return result;

        }
        private static string BuildEnum(string result, List<Type> types)
        {
            types = types.Distinct().ToList();
            result += "\nNetEventDefine.Enums = {\n";
            foreach (var type in types)
            {
                string name = type.Name;
                result += $"\t{name} = {left}\n";
                var arr = Enum.GetValues(type);
                foreach (var val in arr)
                {
                    string _name = val.ToString();
                    var code = Convert.GetTypeCode(val);
                    long value = Convert.ToInt64(val);
                    result += $"\t\t{_name} = {value},\n";
                }
                result += $"\t{right},\n";
            }
            result += "}\n";
            return result;
        }
        private static string BuidRequestAndResponse(List<Type> types)
        {
            string result = "\nNetEventDefine = {\n";

            foreach (Type type in types)
            {
                NetMessageCode h = type.GetCustomAttributes(typeof(NetMessageCode), false).First() as NetMessageCode;
                uint subId = h.SubId;

                result += $"\t{type.Name} = {left}\n" +
                    $"\t\tMainId = {h.MainId},\n" +
                    $"\t\tSubId = {h.SubId},\n" +
                    $"\t{right},\n";
            }
            Log.E("---------------EmmyLua 服务器消息结构已变更需要重新编写导出逻辑----------------------------");
            return result + "}\n";
        }

        private static Dictionary<Type, string> typeMap = new Dictionary<Type, string>()
        {
            {typeof(System.String), "string"},
            {typeof(System.Char), "string"},

            {typeof(System.Int16), "number"},
            {typeof(System.Int32), "number"},
            {typeof(System.Int64), "number"},
            {typeof(System.UInt16), "number"},
            {typeof(System.UInt32), "number"},
            {typeof(System.UInt64), "number"},
            {typeof(System.Single), "number"},
            {typeof(System.Double), "number"},
            {typeof(System.DateTime), "number"},


            {typeof(System.Boolean), "boolean"},
        };

        public static string GetLuaType(Type type)
        {
            if (typeMap.ContainsKey(type))
            {
                return typeMap[type];
            }

            return string.Empty;
        }

        private static string BuildString(Type type, string result, List<Type> other, List<Type> enumTypes)
        {
            string className = type.Name;
            result += $"\n---@class {className}";

            if (!type.IsEnum)
            {
                result += $"\n";
                var fileds = type.GetFields();

                foreach (var field in fileds)
                {
                    var _type = field.FieldType;
                    var luaType = GetLuaType(_type);

                    if (string.IsNullOrEmpty(luaType))
                    {
                        if (_type.IsSubclassOfGeneric(typeof(List<>)))
                        {
                            var eles = _type.GetGenericArguments();
                            _type = eles[0].MakeArrayType();
                        }
                        if (_type.IsArray)
                        {
                            var element_type = _type.GetElementType();
                            luaType = $"{element_type.Name}[]";
                            other.Add(element_type);
                        }
                        else
                        {
                            luaType = _type.Name;
                            other.Add(_type);
                        }

                    }
                    result += $"---@field {field.Name} {luaType}\n";
                }
                var ps = type.GetProperties();
                foreach (var p in ps)
                {
                    var _type = p.PropertyType;
                    var luaType = GetLuaType(_type);

                    if (string.IsNullOrEmpty(luaType))
                    {
                        if (_type.IsSubclassOfGeneric(typeof(List<>)))
                        {
                            var eles = _type.GetGenericArguments();
                            _type = eles[0].MakeArrayType();
                        }
                        if (_type.IsArray)
                        {
                            var element_type = _type.GetElementType();
                            luaType = $"{element_type.Name}[]";
                            other.Add(element_type);
                        }

                        else
                        {
                            luaType = _type.Name;
                            other.Add(_type);
                        }
                    }
                    result += $"---@field {p.Name} {luaType}\n";
                }
            }
            else
            {
                result += $" Enum\n";
                enumTypes.Add(type);
            }


            return result;
        }

        private static string BuildOther(string result, List<Type> other, List<Type> enumTypes)
        {
            List<Type> types = new List<Type>(other);
            other.Clear();
            types = types.Distinct().ToList();
            foreach (var type in types)
            {
                result = BuildString(type, result, other, enumTypes);
            }

            if (other.Count != 0)
            {
                result = BuildOther(result, other, enumTypes);
            }

            return result;
        }
    }
}