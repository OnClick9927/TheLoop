using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace IFramework
{
    public static class Ex
    {
        /// <summary>
        ///         取绝对值
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static float Abs(this float self)
        {
            return Math.Abs(self);
        }
        /// <summary>
        /// 限制在 min-max之间
        /// </summary>
        /// <param name="self"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static float Clamp(this float self, float min, float max)
        {
            return self < min ? min : self > max ? max : self;
        }
        /// <summary>
        /// 限制在0-1
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static float Clamp01(this float self)
        {
            return Clamp(self, 0f, 1f);
        }
        /// <summary>
        /// 获取比self小的最大整数
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int Floor(this float self)
        {
            return (int)Math.Floor(self);
        }
        /// <summary>
        /// 从0-length 重复
        /// </summary>
        /// <param name="self"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static float Repeat(this float self, float length)
        {
            return Clamp(self - (float)Math.Floor(self / length) * length, 0f, length);
        }
        /// <summary>
        /// 找到最近的 int
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int RoundToInt(this float self)
        {
            return (int)Math.Round((double)self);
        }
        /// <summary>
        /// 插值
        /// </summary>
        /// <param name="self"></param>
        /// <param name="end"></param>
        /// <param name="pecent"></param>
        /// <returns></returns>
        public static float Lerp(this float self, float end, float pecent)
        {
            return self + (end - self) * pecent.Clamp01();
        }

        /// <summary>
        /// 约束数值大小
        /// </summary>
        /// <param name="self"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static int Clamp(this int self, int min, int max)
        {
            return self < min ? min : self > max ? max : self;
        }
        /// <summary>
        /// 线性插值  self  +（end-self）* percent
        /// </summary>
        /// <param name="self"></param>
        /// <param name="end"></param>
        /// <param name="pecent"></param>
        /// <returns></returns>
        public static int Lerp(this int self, float end, float pecent)
        {
            float _tem = self;
            return _tem.Lerp(end, pecent).RoundToInt();
        }


        /// <summary>
        /// 是否存在文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ExistFile(this string path)
        {
            return File.Exists(path);
        }
        /// <summary>
        /// 是否是一个文件夹
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsDirectory(this string path)
        {
            FileInfo fi = new FileInfo(path);
            if ((fi.Attributes & FileAttributes.Directory) != 0)
                return true;
            return false;
        }

        /// <summary>
        /// 移除空文件夹
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool RemoveEmptyDirectory(this string path)
        {
            if (string.IsNullOrEmpty(path)) throw new Exception("Directory name is invalid.");
            try
            {
                if (!Directory.Exists(path)) return false;
                string[] subDirectoryNames = Directory.GetDirectories(path, "*");
                int subDirectoryCount = subDirectoryNames.Length;
                foreach (string subDirectoryName in subDirectoryNames)
                {
                    if (RemoveEmptyDirectory(subDirectoryName))
                    {
                        subDirectoryCount--;
                    }
                }
                if (subDirectoryCount > 0) return false;
                if (Directory.GetFiles(path, "*").Length > 0) return false;
                Directory.Delete(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 拼接路径
        /// </summary>
        /// <param name="path"></param>
        /// <param name="toCombinePath"></param>
        /// <returns></returns>
        public static string CombinePath(this string path, string toCombinePath)
        {
            return Path.Combine(path, toCombinePath).ToRegularPath();
        }
        /// <summary>
        /// 拼接路径
        /// </summary>
        /// <param name="path"></param>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string CombinePath(this string path, string[] paths)
        {
            for (int i = 1; i < paths.Length; i++)
            {
                path = path.CombinePath(paths[i]);
            }
            return path.ToRegularPath();
        }

        /// <summary>
        /// 规范路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ToRegularPath(this string path)
        {
            path = path.Replace('\\', '/');
            return path;
        }

        /// <summary>
        /// 如果文件夹不存在则创建
        /// </summary>
        /// <param name="path"></param>
        public static void MakeDirectoryExist(this string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        /// <summary>
        /// 强转
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T As<T>(this object obj) where T : class
        {
            if (obj == null)
            {
                return default(T);
            }
            return obj as T;
        }
        /// <summary>
        /// 对象是否是该类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool Is<T>(this object obj)
        {
            return obj is T;
        }
        /// <summary>
        /// 获取当前程序集中的类型的子类，3.5有问题
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetSubTypesInAssembly(this Type self)
        {
            if (self.IsInterface)
                return Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .Where(item => item.GetInterfaces().Contains(self));
            return Assembly.GetExecutingAssembly()
                           .GetTypes()
                           .Where(item => item.IsSubclassOf(self));
        }
        /// <summary>
        /// 获取所有程序集中的类型的子类，3.5有问题
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetSubTypesInAssemblys(this Type self)
        {
            if (self.IsInterface)
                return AppDomain.CurrentDomain.GetAssemblies()
                                .SelectMany(item => item.GetTypes())
                                .Where(item => item.GetInterfaces().Contains(self));
            return AppDomain.CurrentDomain.GetAssemblies()
                            .SelectMany(item => item.GetTypes())
                            .Where(item => item.IsSubclassOf(self));
        }

        /// <summary>
        /// 是否继承接口
        /// </summary>
        /// <param name="self"></param>
        /// <param name="Interface"></param>
        /// <returns></returns>
        public static bool IsExtendInterface(this Type self, Type Interface)
        {
            return self.GetInterfaces().Contains(Interface);
        }

        /// <summary>
        /// 是否继承自泛型类
        /// </summary>
        /// <param name="self"></param>
        /// <param name="genericType"></param>
        /// <returns></returns>
        public static bool IsSubclassOfGeneric(this Type self, Type genericType)
        {
#if NETFX_CORE
                if (!genericTypeDefinition.GetTypeInfo().IsGenericTypeDefinition)
#else
            if (!genericType.IsGenericTypeDefinition)
#endif
                return false;

#if NETFX_CORE
                if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition().Equals(genericTypeDefinition))
#else
            if (self.IsGenericType && self.GetGenericTypeDefinition().Equals(genericType))
#endif
                return true;

#if NETFX_CORE
                Type baseType = type.GetTypeInfo().BaseType;
#else
            Type baseType = self.BaseType;
#endif
            if (baseType != null && baseType != typeof(object))
            {
                if (IsSubclassOfGeneric(baseType, genericType))
                    return true;
            }

            foreach (Type t in self.GetInterfaces())
            {
                if (IsSubclassOfGeneric(t, genericType))
                    return true;
            }

            return false;
        }
        /// <summary>
        /// 获取类型树
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<Type> GetTypeTree(this Type t)
        {
            var tmp = t;
            var types = new List<Type>();
            do
            {
                types.Add(t);
                t = t.BaseType;
            } while (t != null);
            types.AddRange(tmp.GetInterfaces());
            return types;
        }
        /// <summary>
        /// 获取程序集下的静态扩展
        /// </summary>
        /// <param name="self"></param>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetExtensionMethods(this Type self, Assembly assembly)
        {
            var query = from type in assembly.GetTypes()
                        where !type.IsGenericType && !type.IsNested
                        from method in type.GetMethods(BindingFlags.Static
                            | BindingFlags.Public | BindingFlags.NonPublic)
                        where method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false)
                        where method.GetParameters()[0].ParameterType == self
                        select method;
            return query;
        }


        /// <summary>
        /// 字符串结尾转Unix编码
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ToUnixLineEndings(this string self)
        {
            return self.Replace("\r\n", "\n").Replace("\r", "\n");
        }
        /// <summary>
        /// 在字符串前拼接字符串
        /// </summary>
        /// <param name="self"></param>
        /// <param name="toPrefix"></param>
        /// <returns></returns>
        public static string AppendHead(this string self, string toPrefix)
        {
            return new StringBuilder(toPrefix).Append(self).ToString();
        }


        /// <summary>
        /// 拼接字符串
        /// </summary>
        /// <param name="self"></param>
        /// <param name="toAppend"></param>
        /// <returns></returns>
        public static string Append(this string self, string toAppend)
        {
            return new StringBuilder(self).Append(toAppend).ToString();
        }

        /// <summary>
        /// 拼接字符串
        /// </summary>
        /// <param name="self"></param>
        /// <param name="toAppend"></param>
        /// <returns></returns>
        public static string Append(this string self, params string[] toAppend)
        {
            if (toAppend == null)
            {
                return self;
            }
            StringBuilder result = new StringBuilder(self);
            foreach (string str in toAppend)
            {
                result = result.Append(str);
            }
            return result.ToString();
        }


    }

}
