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
    public class IFrameworkTweensTweenWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Tweens.Tween);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 7, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Run", _m_Run);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReStart", _m_ReStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rewind", _m_Rewind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Complete", _m_Complete);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetConverter", _m_SetConverter);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "onCompelete", _e_onCompelete);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "direction", _g_get_direction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoRecyle", _g_get_autoRecyle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snap", _g_get_snap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loopType", _g_get_loopType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loop", _g_get_loop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "converter", _g_get_converter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "duration", _g_get_duration);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoRecyle", _s_set_autoRecyle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snap", _s_set_snap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "loopType", _s_set_loopType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "loop", _s_set_loop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "converter", _s_set_converter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "duration", _s_set_duration);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.Tweens.Tween does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Run(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Run(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ReStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rewind(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float _duration = (float)LuaAPI.lua_tonumber(L, 2);
                    bool _snap = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Rewind( _duration, _snap );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _duration = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.Rewind( _duration );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Tweens.Tween.Rewind!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Complete(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _invoke = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Complete( _invoke );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetConverter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Tweens.IPercentConverter _converter = (IFramework.Tweens.IPercentConverter)translator.GetObject(L, 2, typeof(IFramework.Tweens.IPercentConverter));
                    
                        IFramework.Tweens.ITween gen_ret = gen_to_be_invoked.SetConverter( _converter );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_direction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.direction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoRecyle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoRecyle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.snap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loopType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.loopType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.loop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_converter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.converter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_duration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.duration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoRecyle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoRecyle = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snap = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loopType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                IFramework.Tweens.LoopType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.loopType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.loop = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_converter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.converter = (IFramework.Tweens.IPercentConverter)translator.GetObject(L, 2, typeof(IFramework.Tweens.IPercentConverter));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_duration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.duration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_onCompelete(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			IFramework.Tweens.Tween gen_to_be_invoked = (IFramework.Tweens.Tween)translator.FastGetCSObj(L, 1);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.onCompelete += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.onCompelete -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to IFramework.Tweens.Tween.onCompelete!");
            return 0;
        }
        
		
		
    }
}
