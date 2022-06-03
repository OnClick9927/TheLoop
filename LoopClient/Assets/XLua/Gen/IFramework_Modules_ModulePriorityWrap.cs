#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class IFrameworkModulesModulePriorityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.ModulePriority);
			Utils.BeginObjectRegister(type, L, translator, 2, 0, 1, 1);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", __AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", __SubMeta);
            
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "value", _g_get_value);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "value", _s_set_value);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FromValue", _m_FromValue_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Config", IFramework.Modules.ModulePriority.Config);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loom", IFramework.Modules.ModulePriority.Loom);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Recorder", IFramework.Modules.ModulePriority.Recorder);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Coroutine", IFramework.Modules.ModulePriority.Coroutine);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Message", IFramework.Modules.ModulePriority.Message);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ECS", IFramework.Modules.ModulePriority.ECS);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FSM", IFramework.Modules.ModulePriority.FSM);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", IFramework.Modules.ModulePriority.Custom);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _value = LuaAPI.xlua_tointeger(L, 2);
					
					IFramework.Modules.ModulePriority gen_ret = new IFramework.Modules.ModulePriority(_value);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(IFramework.Modules.ModulePriority));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.ModulePriority constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __AddMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<IFramework.Modules.ModulePriority>(L, 1) && translator.Assignable<IFramework.Modules.ModulePriority>(L, 2))
				{
					IFramework.Modules.ModulePriority leftside;translator.Get(L, 1, out leftside);
					IFramework.Modules.ModulePriority rightside;translator.Get(L, 2, out rightside);
					
					translator.Push(L, leftside + rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need IFramework.Modules.ModulePriority!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __SubMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<IFramework.Modules.ModulePriority>(L, 1) && translator.Assignable<IFramework.Modules.ModulePriority>(L, 2))
				{
					IFramework.Modules.ModulePriority leftside;translator.Get(L, 1, out leftside);
					IFramework.Modules.ModulePriority rightside;translator.Get(L, 2, out rightside);
					
					translator.Push(L, leftside - rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need IFramework.Modules.ModulePriority!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FromValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        IFramework.Modules.ModulePriority gen_ret = IFramework.Modules.ModulePriority.FromValue( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.ModulePriority gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.ModulePriority gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.value = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
