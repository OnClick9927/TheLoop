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
    public class IFrameworkModulesMessageMessageModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Message.MessageModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 3, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Subscribe", _m_Subscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnSubscribe", _m_UnSubscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Publish", _m_Publish);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PublishByNumber", _m_PublishByNumber);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "count", _g_get_count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fitSubType", _g_get_fitSubType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "processesPerFrame", _g_get_processesPerFrame);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fitSubType", _s_set_fitSubType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "processesPerFrame", _s_set_processesPerFrame);
            
			
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
					
					IFramework.Modules.Message.MessageModule gen_ret = new IFramework.Modules.Message.MessageModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Message.MessageModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Subscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.Modules.Message.IMessageListener>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.Modules.Message.IMessageListener _listener = (IFramework.Modules.Message.IMessageListener)translator.GetObject(L, 3, typeof(IFramework.Modules.Message.IMessageListener));
                    
                    gen_to_be_invoked.Subscribe( _type, _listener );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.Modules.Message.MessageListener>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.Modules.Message.MessageListener _listener = translator.GetDelegate<IFramework.Modules.Message.MessageListener>(L, 3);
                    
                    gen_to_be_invoked.Subscribe( _type, _listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Message.MessageModule.Subscribe!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnSubscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.Modules.Message.IMessageListener>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.Modules.Message.IMessageListener _listener = (IFramework.Modules.Message.IMessageListener)translator.GetObject(L, 3, typeof(IFramework.Modules.Message.IMessageListener));
                    
                    gen_to_be_invoked.UnSubscribe( _type, _listener );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.Modules.Message.MessageListener>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.Modules.Message.MessageListener _listener = translator.GetDelegate<IFramework.Modules.Message.MessageListener>(L, 3);
                    
                    gen_to_be_invoked.UnSubscribe( _type, _listener );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Message.MessageModule.UnSubscribe!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Publish(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.IEventArgs>(L, 3)&& translator.Assignable<IFramework.Modules.Message.MessageUrgencyType>(L, 4)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.IEventArgs _args = (IFramework.IEventArgs)translator.GetObject(L, 3, typeof(IFramework.IEventArgs));
                    IFramework.Modules.Message.MessageUrgencyType _priority;translator.Get(L, 4, out _priority);
                    
                        IFramework.Modules.Message.IMessage gen_ret = gen_to_be_invoked.Publish( _type, _args, _priority );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.IEventArgs>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.IEventArgs _args = (IFramework.IEventArgs)translator.GetObject(L, 3, typeof(IFramework.IEventArgs));
                    
                        IFramework.Modules.Message.IMessage gen_ret = gen_to_be_invoked.Publish( _type, _args );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Message.MessageModule.Publish!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PublishByNumber(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.IEventArgs>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.IEventArgs _args = (IFramework.IEventArgs)translator.GetObject(L, 3, typeof(IFramework.IEventArgs));
                    int _priority = LuaAPI.xlua_tointeger(L, 4);
                    
                        IFramework.Modules.Message.IMessage gen_ret = gen_to_be_invoked.PublishByNumber( _type, _args, _priority );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<IFramework.IEventArgs>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    IFramework.IEventArgs _args = (IFramework.IEventArgs)translator.GetObject(L, 3, typeof(IFramework.IEventArgs));
                    
                        IFramework.Modules.Message.IMessage gen_ret = gen_to_be_invoked.PublishByNumber( _type, _args );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Message.MessageModule.PublishByNumber!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fitSubType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.fitSubType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processesPerFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.processesPerFrame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fitSubType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fitSubType = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_processesPerFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Message.MessageModule gen_to_be_invoked = (IFramework.Modules.Message.MessageModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.processesPerFrame = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
