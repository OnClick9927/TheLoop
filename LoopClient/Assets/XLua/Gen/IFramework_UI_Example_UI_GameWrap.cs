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
using IFramework;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class IFrameworkUIExampleUI_GameWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.Example.UI_Game);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsync", _m_LoadAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Startup", _m_Startup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeComponentExist", _m_MakeComponentExist);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RmoveComponent", _m_RmoveComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalIdentity", _m_LocalIdentity);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "module", _g_get_module);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "module", _s_set_module);
            
			
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
					
					IFramework.UI.Example.UI_Game gen_ret = new IFramework.UI.Example.UI_Game();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.UI.Example.UI_Game constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Init(  );
                    
                    
                    
                    return 0;
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
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        IFramework.UI.UIPanel gen_ret = gen_to_be_invoked.Load( ref _name );
                        translator.Push(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _name);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    IFramework.UI.LoadPanelAsyncOperation _op = (IFramework.UI.LoadPanelAsyncOperation)translator.GetObject(L, 3, typeof(IFramework.UI.LoadPanelAsyncOperation));
                    
                        bool gen_ret = gen_to_be_invoked.LoadAsync( ref _name, _op );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _name);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Startup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Startup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeComponentExist(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Component gen_ret = gen_to_be_invoked.MakeComponentExist(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RmoveComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RmoveComponent(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalIdentity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Component gen_ret = gen_to_be_invoked.LocalIdentity(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.module);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.UI_Game gen_to_be_invoked = (IFramework.UI.Example.UI_Game)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.module = (IFramework.UI.UIModule)translator.GetObject(L, 2, typeof(IFramework.UI.UIModule));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
