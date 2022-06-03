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
    public class LoopClientLoopClientPanelConfig_RTDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoopClient.LoopClientPanelConfig_RT.Data);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 3, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "panelName", _g_get_panelName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layer", _g_get_layer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layerOrder", _g_get_layerOrder);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "panelName", _s_set_panelName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layer", _s_set_layer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layerOrder", _s_set_layerOrder);
            
			
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
					
					LoopClient.LoopClientPanelConfig_RT.Data gen_ret = new LoopClient.LoopClientPanelConfig_RT.Data();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoopClient.LoopClientPanelConfig_RT.Data constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.panelName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.layer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layerOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layerOrder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panelName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                IFramework.UI.UILayer gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.layer = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layerOrder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientPanelConfig_RT.Data gen_to_be_invoked = (LoopClient.LoopClientPanelConfig_RT.Data)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.layerOrder = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
