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
    public class LoopClientLoopClientGameUnityModulesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoopClient.LoopClientGame.UnityModules);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateUI", _g_get_UpdateUI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UI", _g_get_UI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Audio", _g_get_Audio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Lua", _g_get_Lua);
            
			
			
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
					
					LoopClient.LoopClientGame.UnityModules gen_ret = new LoopClient.LoopClientGame.UnityModules();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoopClient.LoopClientGame.UnityModules constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateUI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientGame.UnityModules gen_to_be_invoked = (LoopClient.LoopClientGame.UnityModules)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.UpdateUI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientGame.UnityModules gen_to_be_invoked = (LoopClient.LoopClientGame.UnityModules)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.UI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Audio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientGame.UnityModules gen_to_be_invoked = (LoopClient.LoopClientGame.UnityModules)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Audio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Lua(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.LoopClientGame.UnityModules gen_to_be_invoked = (LoopClient.LoopClientGame.UnityModules)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Lua);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
