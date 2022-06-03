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
    public class IFrameworkModulesFsmTransitionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Fsm.Transition);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BindCondition", _m_BindCondition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnBindCondition", _m_UnBindCondition);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "head", _g_get_head);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trail", _g_get_trail);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "head", _s_set_head);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trail", _s_set_trail);
            
			
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
					
					IFramework.Modules.Fsm.Transition gen_ret = new IFramework.Modules.Fsm.Transition();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.Transition constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BindCondition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<IFramework.Modules.Fsm.ICondition>(L, 2)) 
                {
                    IFramework.Modules.Fsm.ICondition _condtion = (IFramework.Modules.Fsm.ICondition)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.ICondition));
                    
                    gen_to_be_invoked.BindCondition( _condtion );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Func<bool>>(L, 2)) 
                {
                    System.Func<bool> _condtion = translator.GetDelegate<System.Func<bool>>(L, 2);
                    
                    gen_to_be_invoked.BindCondition( _condtion );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.Transition.BindCondition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnBindCondition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<IFramework.Modules.Fsm.ICondition>(L, 2)) 
                {
                    IFramework.Modules.Fsm.ICondition _condtion = (IFramework.Modules.Fsm.ICondition)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.ICondition));
                    
                    gen_to_be_invoked.UnBindCondition( _condtion );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Func<bool>>(L, 2)) 
                {
                    System.Func<bool> _condtion = translator.GetDelegate<System.Func<bool>>(L, 2);
                    
                    gen_to_be_invoked.UnBindCondition( _condtion );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.Transition.UnBindCondition!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_head(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.head);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.trail);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_head(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.head = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trail(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                IFramework.Modules.Fsm.Transition gen_to_be_invoked = (IFramework.Modules.Fsm.Transition)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trail = (IFramework.Modules.Fsm.IState)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.IState));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
