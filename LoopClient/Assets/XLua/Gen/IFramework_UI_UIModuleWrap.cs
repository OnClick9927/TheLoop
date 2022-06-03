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
    public class IFrameworkUIUIModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.UIModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 20, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItem", _m_GetItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItem", _m_SetItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetItemLoader", _m_SetItemLoader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetReleaseAsset", _m_SetReleaseAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateCanvas", _m_CreateCanvas);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCanvas", _m_SetCanvas);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddLoader", _m_AddLoader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGroups", _m_SetGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayerConfig", _m_SetLayerConfig);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutCamera", _m_PutCamera);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetArg", _m_SetArg);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveArg", _m_RemoveArg);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetArg", _m_GetArg);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Find", _m_Find);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Show", _m_Show);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Hide", _m_Hide);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", _m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Resume", _m_Resume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "canvas", _g_get_canvas);
            
			
			
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
					
					IFramework.UI.UIModule gen_ret = new IFramework.UI.UIModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.UI.UIModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.GameObject gen_ret = gen_to_be_invoked.GetItem( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    
                    gen_to_be_invoked.SetItem( _name, _go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetItemLoader(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Func<string, UnityEngine.GameObject> _loader = translator.GetDelegate<System.Func<string, UnityEngine.GameObject>>(L, 2);
                    
                    gen_to_be_invoked.SetItemLoader( _loader );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetReleaseAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action<string> _releaseAsset = translator.GetDelegate<System.Action<string>>(L, 2);
                    
                    gen_to_be_invoked.SetReleaseAsset( _releaseAsset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateCanvas(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CreateCanvas(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCanvas(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Canvas _canvas = (UnityEngine.Canvas)translator.GetObject(L, 2, typeof(UnityEngine.Canvas));
                    
                    gen_to_be_invoked.SetCanvas( _canvas );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLoader(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.UI.IPanelLoader _loader = (IFramework.UI.IPanelLoader)translator.GetObject(L, 2, typeof(IFramework.UI.IPanelLoader));
                    
                    gen_to_be_invoked.AddLoader( _loader );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGroups(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.UI.IGroups _groups = (IFramework.UI.IGroups)translator.GetObject(L, 2, typeof(IFramework.UI.IGroups));
                    
                    gen_to_be_invoked.SetGroups( _groups );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayerConfig(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.UI.UILayerConfig[] _config = (IFramework.UI.UILayerConfig[])translator.GetObject(L, 2, typeof(IFramework.UI.UILayerConfig[]));
                    
                    gen_to_be_invoked.SetLayerConfig( _config );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutCamera(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
                    
                    gen_to_be_invoked.PutCamera( _camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetArg(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    IFramework.IEventArgs _arg = (IFramework.IEventArgs)translator.GetObject(L, 3, typeof(IFramework.IEventArgs));
                    
                    gen_to_be_invoked.SetArg( _name, _arg );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.RemoveArg( _name );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        IFramework.IEventArgs gen_ret = gen_to_be_invoked.GetArg( _name );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        IFramework.UI.UIPanel gen_ret = gen_to_be_invoked.Find( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Action<IFramework.UI.UIPanel> _callback = translator.GetDelegate<System.Action<IFramework.UI.UIPanel>>(L, 3);
                    
                    gen_to_be_invoked.Load( _name, _callback );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Show( _name );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Hide( _name );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Pause( _name );
                    
                    
                    
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
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Resume( _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Close( _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canvas(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.UIModule gen_to_be_invoked = (IFramework.UI.UIModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.canvas);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
