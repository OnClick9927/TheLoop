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
    public class LoopClientAudioEntityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoopClient.AudioEntity);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "source", _g_get_source);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "module", _g_get_module);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sound", _g_get_sound);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "source", _s_set_source);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "module", _s_set_module);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sound", _s_set_sound);
            
			
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.AudioSource>(L, 2))
				{
					UnityEngine.AudioSource _source = (UnityEngine.AudioSource)translator.GetObject(L, 2, typeof(UnityEngine.AudioSource));
					
					LoopClient.AudioEntity gen_ret = new LoopClient.AudioEntity(_source);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoopClient.AudioEntity constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AudioClip _audio = (UnityEngine.AudioClip)translator.GetObject(L, 2, typeof(UnityEngine.AudioClip));
                    bool _loop = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Play( _audio, _loop );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_source(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.source);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.module);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.sound);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_source(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.source = (UnityEngine.AudioSource)translator.GetObject(L, 2, typeof(UnityEngine.AudioSource));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.module = (LoopClient.AudioModule)translator.GetObject(L, 2, typeof(LoopClient.AudioModule));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sound(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioEntity gen_to_be_invoked = (LoopClient.AudioEntity)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sound = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
