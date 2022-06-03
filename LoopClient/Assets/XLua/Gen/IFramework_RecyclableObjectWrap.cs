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
    public class IFrameworkRecyclableObjectWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.RecyclableObject);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Recyle", _m_Recyle);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "recyled", _g_get_recyled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "env", _g_get_env);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "guid", _g_get_guid);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Allocate", _m_Allocate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RecyleByGuid", _m_RecyleByGuid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RecyleAll", _m_RecyleAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFromMemory", _m_GetFromMemory_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.RecyclableObject does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Allocate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 1)&& translator.Assignable<IFramework.EnvironmentType>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    IFramework.EnvironmentType _envType;translator.Get(L, 2, out _envType);
                    
                        IFramework.RecyclableObject gen_ret = IFramework.RecyclableObject.Allocate( _type, _envType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 1)&& translator.Assignable<IFramework.IEnvironment>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    IFramework.IEnvironment _env = (IFramework.IEnvironment)translator.GetObject(L, 2, typeof(IFramework.IEnvironment));
                    
                        IFramework.RecyclableObject gen_ret = IFramework.RecyclableObject.Allocate( _type, _env );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.RecyclableObject.Allocate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecyleByGuid_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<IFramework.IEnvironment>(L, 1)&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    IFramework.IEnvironment _env = (IFramework.IEnvironment)translator.GetObject(L, 1, typeof(IFramework.IEnvironment));
                    System.Guid _guid;translator.Get(L, 2, out _guid);
                    
                    IFramework.RecyclableObject.RecyleByGuid( _env, _guid );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<IFramework.EnvironmentType>(L, 1)&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    IFramework.EnvironmentType _envType;translator.Get(L, 1, out _envType);
                    System.Guid _guid;translator.Get(L, 2, out _guid);
                    
                    IFramework.RecyclableObject.RecyleByGuid( _envType, _guid );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.RecyclableObject.RecyleByGuid!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RecyleAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<IFramework.IEnvironment>(L, 1)) 
                {
                    IFramework.IEnvironment _env = (IFramework.IEnvironment)translator.GetObject(L, 1, typeof(IFramework.IEnvironment));
                    
                    IFramework.RecyclableObject.RecyleAll( _env );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<IFramework.EnvironmentType>(L, 1)) 
                {
                    IFramework.EnvironmentType _envType;translator.Get(L, 1, out _envType);
                    
                    IFramework.RecyclableObject.RecyleAll( _envType );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.RecyclableObject.RecyleAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFromMemory_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<IFramework.IEnvironment>(L, 1)&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    IFramework.IEnvironment _env = (IFramework.IEnvironment)translator.GetObject(L, 1, typeof(IFramework.IEnvironment));
                    System.Guid _id;translator.Get(L, 2, out _id);
                    IFramework.RecyclableObject _obj;
                    
                        bool gen_ret = IFramework.RecyclableObject.GetFromMemory( _env, _id, out _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _obj);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& translator.Assignable<IFramework.EnvironmentType>(L, 1)&& translator.Assignable<System.Guid>(L, 2)) 
                {
                    IFramework.EnvironmentType _envType;translator.Get(L, 1, out _envType);
                    System.Guid _id;translator.Get(L, 2, out _id);
                    IFramework.RecyclableObject _obj;
                    
                        bool gen_ret = IFramework.RecyclableObject.GetFromMemory( _envType, _id, out _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _obj);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.RecyclableObject.GetFromMemory!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Recyle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.RecyclableObject gen_to_be_invoked = (IFramework.RecyclableObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Recyle(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_recyled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.RecyclableObject gen_to_be_invoked = (IFramework.RecyclableObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.recyled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_env(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.RecyclableObject gen_to_be_invoked = (IFramework.RecyclableObject)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.env);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_guid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.RecyclableObject gen_to_be_invoked = (IFramework.RecyclableObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.guid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
