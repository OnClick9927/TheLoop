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
    public class IFrameworkModulesFsmBoolConditionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Fsm.BoolCondition);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsMetCondition", _m_IsMetCondition);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<IFramework.Modules.Fsm.ConditionValue<bool>>(L, 2) && translator.Assignable<object>(L, 3) && translator.Assignable<IFramework.Modules.Fsm.CompareType>(L, 4))
				{
					IFramework.Modules.Fsm.ConditionValue<bool> _conditionValue = (IFramework.Modules.Fsm.ConditionValue<bool>)translator.GetObject(L, 2, typeof(IFramework.Modules.Fsm.ConditionValue<bool>));
					object _compareValue = translator.GetObject(L, 3, typeof(object));
					IFramework.Modules.Fsm.CompareType _compareType;translator.Get(L, 4, out _compareType);
					
					IFramework.Modules.Fsm.BoolCondition gen_ret = new IFramework.Modules.Fsm.BoolCondition(_conditionValue, _compareValue, _compareType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Fsm.BoolCondition constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsMetCondition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Fsm.BoolCondition gen_to_be_invoked = (IFramework.Modules.Fsm.BoolCondition)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsMetCondition(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
