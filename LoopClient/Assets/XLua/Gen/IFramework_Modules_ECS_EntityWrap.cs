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
    public class IFrameworkModulesECSEntityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.ECS.Entity);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", _m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", _m_AddComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveComponent", _m_RemoveComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsComponent", _m_ContainsComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReFreshComponent", _m_ReFreshComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Destory", _m_Destory);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "mou", _g_get_mou);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "mou", _s_set_mou);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.Modules.ECS.Entity does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.GetComponent( _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.AddComponent( _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<IFramework.Modules.ECS.IComponent>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    IFramework.Modules.ECS.IComponent _component = (IFramework.Modules.ECS.IComponent)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IComponent));
                    bool _useSame = LuaAPI.lua_toboolean(L, 3);
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.AddComponent( _component, _useSame );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.ECS.Entity.AddComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                    gen_to_be_invoked.RemoveComponent( _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.ContainsComponent( _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReFreshComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.Modules.ECS.IComponent _component = (IFramework.Modules.ECS.IComponent)translator.GetObject(L, 3, typeof(IFramework.Modules.ECS.IComponent));
                    
                    gen_to_be_invoked.ReFreshComponent( _type, _component );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Destory(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Destory(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mou(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.mou);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mou(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.ECS.Entity gen_to_be_invoked = (IFramework.Modules.ECS.Entity)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mou = (IFramework.Modules.ECS.IECSModule)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IECSModule));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
