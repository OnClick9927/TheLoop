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
    public class LoopClientAudioSaveDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoopClient.AudioSaveData);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "soundVolume", _g_get_soundVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "musicVolume", _g_get_musicVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "soundMute", _g_get_soundMute);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "musicMute", _g_get_musicMute);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "soundVolume", _s_set_soundVolume);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "musicVolume", _s_set_musicVolume);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "soundMute", _s_set_soundMute);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "musicMute", _s_set_musicMute);
            
			
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
					
					LoopClient.AudioSaveData gen_ret = new LoopClient.AudioSaveData();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoopClient.AudioSaveData constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.soundVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_musicVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.musicVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundMute(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.soundMute);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_musicMute(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.musicMute);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_soundVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.soundVolume = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_musicVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.musicVolume = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_soundMute(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.soundMute = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_musicMute(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioSaveData gen_to_be_invoked = (LoopClient.AudioSaveData)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.musicMute = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
