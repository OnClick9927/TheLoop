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
    public class IFrameworkHotfixAssetAssetsVersionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Hotfix.Asset.AssetsVersion);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 2);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "versions", _g_get_versions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ticks", _g_get_ticks);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "versions", _s_set_versions);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ticks", _s_set_ticks);
            
			
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
					
					IFramework.Hotfix.Asset.AssetsVersion gen_ret = new IFramework.Hotfix.Asset.AssetsVersion();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Hotfix.Asset.AssetsVersion constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_versions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Hotfix.Asset.AssetsVersion gen_to_be_invoked = (IFramework.Hotfix.Asset.AssetsVersion)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.versions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ticks(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Hotfix.Asset.AssetsVersion gen_to_be_invoked = (IFramework.Hotfix.Asset.AssetsVersion)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.ticks);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_versions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Hotfix.Asset.AssetsVersion gen_to_be_invoked = (IFramework.Hotfix.Asset.AssetsVersion)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.versions = (System.Collections.Generic.List<IFramework.Hotfix.Asset.AssetsVersion.VersionData>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<IFramework.Hotfix.Asset.AssetsVersion.VersionData>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ticks(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Hotfix.Asset.AssetsVersion gen_to_be_invoked = (IFramework.Hotfix.Asset.AssetsVersion)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ticks = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
