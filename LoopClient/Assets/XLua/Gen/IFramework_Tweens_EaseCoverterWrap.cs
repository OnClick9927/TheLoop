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
    public class IFrameworkTweensEaseCoverterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Tweens.EaseCoverter);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Convert", _m_Convert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Config", _m_Config);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Default", _g_get_Default);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Default", _s_set_Default);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					IFramework.Tweens.EaseCoverter gen_ret = new IFramework.Tweens.EaseCoverter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Tweens.EaseCoverter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Convert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.EaseCoverter gen_to_be_invoked = (IFramework.Tweens.EaseCoverter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _percent = (float)LuaAPI.lua_tonumber(L, 2);
                    float _time = (float)LuaAPI.lua_tonumber(L, 3);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        float gen_ret = gen_to_be_invoked.Convert( _percent, _time, _duration );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Config(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Tweens.EaseCoverter gen_to_be_invoked = (IFramework.Tweens.EaseCoverter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Tweens.Ease _value;translator.Get(L, 2, out _value);
                    
                        IFramework.Tweens.IPercentConverter gen_ret = gen_to_be_invoked.Config( _value );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Default(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, IFramework.Tweens.EaseCoverter.Default);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Default(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    IFramework.Tweens.EaseCoverter.Default = (IFramework.Tweens.EaseCoverter)translator.GetObject(L, 1, typeof(IFramework.Tweens.EaseCoverter));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
