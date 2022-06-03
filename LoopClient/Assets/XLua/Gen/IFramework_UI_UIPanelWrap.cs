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
using IFramework;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class IFrameworkUIUIPanelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.UIPanel);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetArgs", _m_SetArgs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveArg", _m_RemoveArg);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetArg", _m_GetArg);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", _m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Resume", _m_Resume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Hide", _m_Hide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Show", _m_Show);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeComponentExist", _m_MakeComponentExist);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RmoveComponent", _m_RmoveComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalIdentity", _m_LocalIdentity);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "module", _g_get_module);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rectTransform", _g_get_rectTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "group", _g_get_group);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "module", _s_set_module);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.UI.UIPanel does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetArgs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.IEventArgs _args = (IFramework.IEventArgs)translator.GetObject(L, 2, typeof(IFramework.IEventArgs));
                    
                    gen_to_be_invoked.SetArgs( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveArg(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RemoveArg(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetArg(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        IFramework.IEventArgs gen_ret = gen_to_be_invoked.GetArg(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Resume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Resume(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Hide(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Hide(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Show(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Show(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeComponentExist(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Component gen_ret = gen_to_be_invoked.MakeComponentExist(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RmoveComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RmoveComponent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalIdentity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Component gen_ret = gen_to_be_invoked.LocalIdentity(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.module);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rectTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rectTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_group(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.group);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.UIPanel gen_to_be_invoked = (IFramework.UI.UIPanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.module = (IFramework.UI.IUIModule)translator.GetObject(L, 2, typeof(IFramework.UI.IUIModule));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
