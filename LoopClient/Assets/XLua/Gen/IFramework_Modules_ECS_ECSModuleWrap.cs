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
    public class IFrameworkModulesECSECSModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.ECS.ECSModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnSubscribeEntity", _m_UnSubscribeEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEntitys", _m_GetEntitys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", _m_AddComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReFreshComponent", _m_ReFreshComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", _m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveComponent", _m_RemoveComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SubscribeSystem", _m_SubscribeSystem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnSubscribeSystem", _m_UnSubscribeSystem);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					IFramework.Modules.ECS.ECSModule gen_ret = new IFramework.Modules.ECS.ECSModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.ECS.ECSModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnSubscribeEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    
                    gen_to_be_invoked.UnSubscribeEntity( _entity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntitys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerable<IFramework.Modules.ECS.IEntity> gen_ret = gen_to_be_invoked.GetEntitys(  );
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
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<IFramework.Modules.ECS.IEntity>(L, 2)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.AddComponent( _entity, _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<IFramework.Modules.ECS.IEntity>(L, 2)&& translator.Assignable<IFramework.Modules.ECS.IComponent>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    IFramework.Modules.ECS.IComponent _component = (IFramework.Modules.ECS.IComponent)translator.GetObject(L, 3, typeof(IFramework.Modules.ECS.IComponent));
                    bool _useSame = LuaAPI.lua_toboolean(L, 4);
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.AddComponent( _entity, _component, _useSame );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.ECS.ECSModule.AddComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReFreshComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    IFramework.Modules.ECS.IComponent _component = (IFramework.Modules.ECS.IComponent)translator.GetObject(L, 4, typeof(IFramework.Modules.ECS.IComponent));
                    
                    gen_to_be_invoked.ReFreshComponent( _entity, _type, _component );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        IFramework.Modules.ECS.IComponent gen_ret = gen_to_be_invoked.GetComponent( _entity, _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IEntity _entity = (IFramework.Modules.ECS.IEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IEntity));
                    System.Type _type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                    gen_to_be_invoked.RemoveComponent( _entity, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SubscribeSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IExcuteSystem _system = (IFramework.Modules.ECS.IExcuteSystem)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IExcuteSystem));
                    
                    gen_to_be_invoked.SubscribeSystem( _system );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnSubscribeSystem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.ECS.ECSModule gen_to_be_invoked = (IFramework.Modules.ECS.ECSModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.ECS.IExcuteSystem _system = (IFramework.Modules.ECS.IExcuteSystem)translator.GetObject(L, 2, typeof(IFramework.Modules.ECS.IExcuteSystem));
                    
                    gen_to_be_invoked.UnSubscribeSystem( _system );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
