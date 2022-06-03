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
    public class IFrameworkHotfixAssetAssetsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Hotfix.Asset.Assets);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 18, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetWebRequestTimeout", _m_GetWebRequestTimeout_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllAssetPaths", _m_GetAllAssetPaths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAssetsSetting", _m_SetAssetsSetting_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VersionCheck", _m_VersionCheck_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DownLoadBundle", _m_DownLoadBundle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Initialized", _m_Initialized_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InitAsync", _m_InitAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAsset", _m_LoadAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadAssetAsync", _m_LoadAssetAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadSceneAssetAsync", _m_LoadSceneAssetAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadSceneAsset", _m_LoadSceneAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Release", _m_Release_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PrepareAssets", _m_PrepareAssets_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogError", _m_LogError_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AssetCreater", _e_AssetCreater);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SceneAssetCreater", _e_SceneAssetCreater);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllAssetPath", _e_GetAllAssetPath);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fastMode", _g_get_fastMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "downloadDirectory", _g_get_downloadDirectory);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fastMode", _s_set_fastMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "downloadDirectory", _s_set_downloadDirectory);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					IFramework.Hotfix.Asset.Assets gen_ret = new IFramework.Hotfix.Asset.Assets();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Hotfix.Asset.Assets constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWebRequestTimeout_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = IFramework.Hotfix.Asset.Assets.GetWebRequestTimeout(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetPaths_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Collections.Generic.IReadOnlyList<string> gen_ret = IFramework.Hotfix.Asset.Assets.GetAllAssetPaths(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAssetsSetting_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Hotfix.Asset.AssetsSetting _setting = (IFramework.Hotfix.Asset.AssetsSetting)translator.GetObject(L, 1, typeof(IFramework.Hotfix.Asset.AssetsSetting));
                    
                    IFramework.Hotfix.Asset.Assets.SetAssetsSetting( _setting );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VersionCheck_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        IFramework.Hotfix.Asset.Assets.CheckBundleVersionOperation gen_ret = IFramework.Hotfix.Asset.Assets.VersionCheck(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownLoadBundle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _bundleName = LuaAPI.lua_tostring(L, 1);
                    
                        IFramework.Hotfix.Asset.Assets.DownLoadBundleOperation gen_ret = IFramework.Hotfix.Asset.Assets.DownLoadBundle( _bundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialized_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        bool gen_ret = IFramework.Hotfix.Asset.Assets.Initialized(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        IFramework.Hotfix.Asset.Assets.LoadManifestOperation gen_ret = IFramework.Hotfix.Asset.Assets.InitAsync(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        IFramework.Hotfix.Asset.Asset gen_ret = IFramework.Hotfix.Asset.Assets.LoadAsset( _path );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        IFramework.Hotfix.Asset.Asset gen_ret = IFramework.Hotfix.Asset.Assets.LoadAssetAsync( _path );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadSceneAssetAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        IFramework.Hotfix.Asset.SceneAsset gen_ret = IFramework.Hotfix.Asset.Assets.LoadSceneAssetAsync( _path );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadSceneAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        IFramework.Hotfix.Asset.SceneAsset gen_ret = IFramework.Hotfix.Asset.Assets.LoadSceneAsset( _path );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Hotfix.Asset.Asset _asset = (IFramework.Hotfix.Asset.Asset)translator.GetObject(L, 1, typeof(IFramework.Hotfix.Asset.Asset));
                    
                    IFramework.Hotfix.Asset.Assets.Release( _asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PrepareAssets_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string[] _paths = (string[])translator.GetObject(L, 1, typeof(string[]));
                    
                        IFramework.Hotfix.Asset.Assets.AssetsGroupOperation gen_ret = IFramework.Hotfix.Asset.Assets.PrepareAssets( _paths );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogError_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _err = LuaAPI.lua_tostring(L, 1);
                    
                    IFramework.Hotfix.Asset.Assets.LogError( _err );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fastMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, IFramework.Hotfix.Asset.Assets.fastMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_downloadDirectory(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, IFramework.Hotfix.Asset.Assets.downloadDirectory);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fastMode(RealStatePtr L)
        {
		    try {
                
			    IFramework.Hotfix.Asset.Assets.fastMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_downloadDirectory(RealStatePtr L)
        {
		    try {
                
			    IFramework.Hotfix.Asset.Assets.downloadDirectory = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_AssetCreater(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.AssetLoadArgs, IFramework.Hotfix.Asset.Asset> gen_delegate = translator.GetDelegate<System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.AssetLoadArgs, IFramework.Hotfix.Asset.Asset>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.AssetLoadArgs, IFramework.Hotfix.Asset.Asset>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					IFramework.Hotfix.Asset.Assets.AssetCreater += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					IFramework.Hotfix.Asset.Assets.AssetCreater -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Hotfix.Asset.Assets.AssetCreater!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SceneAssetCreater(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.SceneAssetLoadArgs, IFramework.Hotfix.Asset.SceneAsset> gen_delegate = translator.GetDelegate<System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.SceneAssetLoadArgs, IFramework.Hotfix.Asset.SceneAsset>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Func<bool, IFramework.Hotfix.Asset.Bundle, System.Collections.Generic.List<IFramework.Hotfix.Asset.Asset>, IFramework.Hotfix.Asset.SceneAssetLoadArgs, IFramework.Hotfix.Asset.SceneAsset>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					IFramework.Hotfix.Asset.Assets.SceneAssetCreater += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					IFramework.Hotfix.Asset.Assets.SceneAssetCreater -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Hotfix.Asset.Assets.SceneAssetCreater!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_GetAllAssetPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Func<System.Collections.Generic.List<string>> gen_delegate = translator.GetDelegate<System.Func<System.Collections.Generic.List<string>>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Func<System.Collections.Generic.List<string>>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					IFramework.Hotfix.Asset.Assets.GetAllAssetPath += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					IFramework.Hotfix.Asset.Assets.GetAllAssetPath -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Hotfix.Asset.Assets.GetAllAssetPath!");
        }
        
    }
}
