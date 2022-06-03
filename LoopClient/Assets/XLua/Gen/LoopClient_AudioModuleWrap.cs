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
    public class LoopClientAudioModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoopClient.AudioModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadData", _m_ReadData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSaveData", _m_GetSaveData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEntity", _m_GetEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEntity", _m_SetEntity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlaySound", _m_PlaySound);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "root", _g_get_root);
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
					
					LoopClient.AudioModule gen_ret = new LoopClient.AudioModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoopClient.AudioModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    LoopClient.AudioSaveData _data = (LoopClient.AudioSaveData)translator.GetObject(L, 2, typeof(LoopClient.AudioSaveData));
                    
                    gen_to_be_invoked.ReadData( _data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSaveData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        LoopClient.AudioSaveData gen_ret = gen_to_be_invoked.GetSaveData(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        LoopClient.AudioEntity gen_ret = gen_to_be_invoked.GetEntity(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEntity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    LoopClient.AudioEntity _entity = (LoopClient.AudioEntity)translator.GetObject(L, 2, typeof(LoopClient.AudioEntity));
                    
                    gen_to_be_invoked.SetEntity( _entity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlaySound(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.PlaySound( _path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_root(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.root);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_soundVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.soundVolume);
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.musicVolume);
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.soundMute);
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.musicMute);
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.soundVolume = (IFramework.ObservableValue<float>)translator.GetObject(L, 2, typeof(IFramework.ObservableValue<float>));
            
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.musicVolume = (IFramework.ObservableValue<float>)translator.GetObject(L, 2, typeof(IFramework.ObservableValue<float>));
            
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.soundMute = (IFramework.ObservableValue<bool>)translator.GetObject(L, 2, typeof(IFramework.ObservableValue<bool>));
            
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
			
                LoopClient.AudioModule gen_to_be_invoked = (LoopClient.AudioModule)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.musicMute = (IFramework.ObservableValue<bool>)translator.GetObject(L, 2, typeof(IFramework.ObservableValue<bool>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
