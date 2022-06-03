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
    public class IFrameworkModulesTimerTimerModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Timer.TimerModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Subscribe", _m_Subscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Allocate", _m_Allocate);
			
			
			
			
			
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
					
					IFramework.Modules.Timer.TimerModule gen_ret = new IFramework.Modules.Timer.TimerModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Timer.TimerModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Timer.TimerModule gen_to_be_invoked = (IFramework.Modules.Timer.TimerModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Subscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Timer.TimerModule gen_to_be_invoked = (IFramework.Modules.Timer.TimerModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Timer.ITimerEntity _entity = (IFramework.Modules.Timer.ITimerEntity)translator.GetObject(L, 2, typeof(IFramework.Modules.Timer.ITimerEntity));
                    
                    gen_to_be_invoked.Subscribe( _entity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Allocate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Timer.TimerModule gen_to_be_invoked = (IFramework.Modules.Timer.TimerModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Action>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Action _action = translator.GetDelegate<System.Action>(L, 2);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 3);
                    int _times = LuaAPI.xlua_tointeger(L, 4);
                    float _timeScale = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        IFramework.Modules.Timer.ITimerEntity gen_ret = gen_to_be_invoked.Allocate( _action, _delay, _times, _timeScale );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Action>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Action _action = translator.GetDelegate<System.Action>(L, 2);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 3);
                    int _times = LuaAPI.xlua_tointeger(L, 4);
                    
                        IFramework.Modules.Timer.ITimerEntity gen_ret = gen_to_be_invoked.Allocate( _action, _delay, _times );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Action>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.Action _action = translator.GetDelegate<System.Action>(L, 2);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        IFramework.Modules.Timer.ITimerEntity gen_ret = gen_to_be_invoked.Allocate( _action, _delay );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Timer.TimerModule.Allocate!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
