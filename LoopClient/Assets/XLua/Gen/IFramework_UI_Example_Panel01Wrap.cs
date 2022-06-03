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
    public class IFrameworkUIExamplePanel01Wrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.UI.Example.Panel01);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeComponentExist", _m_MakeComponentExist);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RmoveComponent", _m_RmoveComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalIdentity", _m_LocalIdentity);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count_Text", _g_get_Count_Text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BTn_ADD", _g_get_BTn_ADD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BTn_SUB", _g_get_BTn_SUB);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BTn_Next", _g_get_BTn_Next);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Count_Text", _s_set_Count_Text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BTn_ADD", _s_set_BTn_ADD);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BTn_SUB", _s_set_BTn_SUB);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BTn_Next", _s_set_BTn_Next);
            
			
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
					
					IFramework.UI.Example.Panel01 gen_ret = new IFramework.UI.Example.Panel01();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.UI.Example.Panel01 constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeComponentExist(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_Count_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Count_Text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BTn_ADD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BTn_ADD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BTn_SUB(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BTn_SUB);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BTn_Next(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BTn_Next);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Count_Text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Count_Text = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BTn_ADD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BTn_ADD = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BTn_SUB(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BTn_SUB = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BTn_Next(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.UI.Example.Panel01 gen_to_be_invoked = (IFramework.UI.Example.Panel01)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BTn_Next = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
