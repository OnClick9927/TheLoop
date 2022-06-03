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
    public class IFrameworkLanguageLanguageModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Language.LanguageModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Subscribe", _m_Subscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnSubscribe", _m_UnSubscribe);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateDelegateObserver", _m_CreateDelegateObserver);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValue", _m_GetValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Publish", _m_Publish);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "language", _g_get_language);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "language", _s_set_language);
            
			
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
					
					IFramework.Language.LanguageModule gen_ret = new IFramework.Language.LanguageModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Language.LanguageModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Subscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Language.ILanguageObserver _observer = (IFramework.Language.ILanguageObserver)translator.GetObject(L, 2, typeof(IFramework.Language.ILanguageObserver));
                    
                    gen_to_be_invoked.Subscribe( _observer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnSubscribe(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Language.ILanguageObserver _observer = (IFramework.Language.ILanguageObserver)translator.GetObject(L, 2, typeof(IFramework.Language.ILanguageObserver));
                    
                    gen_to_be_invoked.UnSubscribe( _observer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDelegateObserver(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        IFramework.Language.IDelegateLanguageObserver gen_ret = gen_to_be_invoked.CreateDelegateObserver( _key );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<IFramework.Language.LanPair>>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Collections.Generic.List<IFramework.Language.LanPair> _pairs = (System.Collections.Generic.List<IFramework.Language.LanPair>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<IFramework.Language.LanPair>));
                    bool _rewrite = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Load( _pairs, _rewrite );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<IFramework.Language.LanPair>>(L, 2)) 
                {
                    System.Collections.Generic.List<IFramework.Language.LanPair> _pairs = (System.Collections.Generic.List<IFramework.Language.LanPair>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<IFramework.Language.LanPair>));
                    
                    gen_to_be_invoked.Load( _pairs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Language.LanguageModule.Load!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SystemLanguage _language;translator.Get(L, 3, out _language);
                    
                        string gen_ret = gen_to_be_invoked.GetValue( _key, _language );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Publish(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.SystemLanguage _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.Publish( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_language(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.language);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_language(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Language.LanguageModule gen_to_be_invoked = (IFramework.Language.LanguageModule)translator.FastGetCSObj(L, 1);
                UnityEngine.SystemLanguage gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.language = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
