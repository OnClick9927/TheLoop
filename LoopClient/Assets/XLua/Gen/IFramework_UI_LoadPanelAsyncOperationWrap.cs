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
    public class IFrameworkUILoadPanelAsyncOperationWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.LoadPanelAsyncOperation);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPanel", _m_SetPanel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetToDefault", _m_SetToDefault);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "callback", _g_get_callback);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panel", _g_get_panel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDone", _g_get_isDone);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panelName", _g_get_panelName);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "callback", _s_set_callback);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panel", _s_set_panel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isDone", _s_set_isDone);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panelName", _s_set_panelName);
            
			
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
					
					IFramework.UI.LoadPanelAsyncOperation gen_ret = new IFramework.UI.LoadPanelAsyncOperation();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.UI.LoadPanelAsyncOperation constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPanel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.UI.UIPanel _panel = (IFramework.UI.UIPanel)translator.GetObject(L, 2, typeof(IFramework.UI.UIPanel));
                    
                    gen_to_be_invoked.SetPanel( _panel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetToDefault(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SetToDefault(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.callback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.panel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isDone(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDone);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.panelName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.callback = translator.GetDelegate<System.Action<IFramework.UI.UIPanel>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panel = (IFramework.UI.UIPanel)translator.GetObject(L, 2, typeof(IFramework.UI.UIPanel));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isDone(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isDone = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.LoadPanelAsyncOperation gen_to_be_invoked = (IFramework.UI.LoadPanelAsyncOperation)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panelName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
