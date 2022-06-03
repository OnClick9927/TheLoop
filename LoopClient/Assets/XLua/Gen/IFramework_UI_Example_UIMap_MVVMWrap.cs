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
    public class IFrameworkUIExampleUIMap_MVVMWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.Example.UIMap_MVVM);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 1, 1);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Panel02", IFramework.UI.Example.UIMap_MVVM.Panel02);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Panel01", IFramework.UI.Example.UIMap_MVVM.Panel01);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "map", _g_get_map);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "map", _s_set_map);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					IFramework.UI.Example.UIMap_MVVM gen_ret = new IFramework.UI.Example.UIMap_MVVM();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.UI.Example.UIMap_MVVM constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_map(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, IFramework.UI.Example.UIMap_MVVM.map);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_map(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    IFramework.UI.Example.UIMap_MVVM.map = (System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, System.Tuple<System.Type, System.Type, System.Type>>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
