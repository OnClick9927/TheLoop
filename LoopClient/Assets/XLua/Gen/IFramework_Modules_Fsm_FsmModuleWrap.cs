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
    public class IFrameworkModulesFsmFsmModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Fsm.FsmModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 4, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Start", _m_Start);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", _m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnPause", _m_UnPause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SubscribeState", _m_SubscribeState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnSubscribeState", _m_UnSubscribeState);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateTransition", _m_CreateTransition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DestoryTransition", _m_DestoryTransition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBool", _m_SetBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInt", _m_SetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat", _m_SetFloat);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "onStateChange", _e_onStateChange);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "exitState", _g_get_exitState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enterState", _g_get_enterState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentState", _g_get_currentState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "runing", _g_get_runing);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "exitState", _s_set_exitState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enterState", _s_set_enterState);
            
			
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
					
					IFramework.Modules.Fsm.FsmModule gen_ret = new IFramework.Modules.Fsm.FsmModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.FsmModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Start(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pause(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnPause(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UnPause(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SubscribeState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Fsm.IState _state = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
                    
                    gen_to_be_invoked.SubscribeState( _state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnSubscribeState(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Fsm.IState _state = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
                    
                    gen_to_be_invoked.UnSubscribeState( _state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateTransition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Fsm.IState _head = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
                    IFramework.Modules.Fsm.IState _trail = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 3, typeof(IFramework.Modules.Fsm.IState));
                    
                        IFramework.Modules.Fsm.Transition gen_ret = gen_to_be_invoked.CreateTransition( _head, _trail );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DestoryTransition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Fsm.IState _head = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
                    IFramework.Modules.Fsm.IState _trail = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 3, typeof(IFramework.Modules.Fsm.IState));
                    
                    gen_to_be_invoked.DestoryTransition( _head, _trail );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _valName = LuaAPI.lua_tostring(L, 2);
                    bool _value = LuaAPI.lua_toboolean(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.SetBool( _valName, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _valName = LuaAPI.lua_tostring(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.SetInt( _valName, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _valName = LuaAPI.lua_tostring(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.SetFloat( _valName, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_exitState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.exitState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enterState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.enterState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.currentState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.runing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_exitState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.exitState = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enterState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enterState = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_onStateChange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			IFramework.Modules.Fsm.FsmModule gen_to_be_invoked = (IFramework.Modules.Fsm.FsmModule)translator.FastGetCSObj(L, 1);
                System.Action<IFramework.Modules.Fsm.IState> gen_delegate = translator.GetDelegate<System.Action<IFramework.Modules.Fsm.IState>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<IFramework.Modules.Fsm.IState>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.onStateChange += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.onStateChange -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.FsmModule.onStateChange!");
            return 0;
        }
        
		
		
    }
}
