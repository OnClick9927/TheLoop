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
    public class IFrameworkModulesCoroutineCoroutineModuleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Modules.Coroutine.CoroutineModule);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartCoroutine", _m_StartCoroutine);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopCoroutine", _m_StopCoroutine);
			
			
			
			
			
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
					
					IFramework.Modules.Coroutine.CoroutineModule gen_ret = new IFramework.Modules.Coroutine.CoroutineModule();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.Modules.Coroutine.CoroutineModule constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartCoroutine(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Coroutine.CoroutineModule gen_to_be_invoked = (IFramework.Modules.Coroutine.CoroutineModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.IEnumerator _routine = (System.Collections.IEnumerator)translator.GetObject(L, 2, typeof(System.Collections.IEnumerator));
                    
                        IFramework.Modules.Coroutine.ICoroutine gen_ret = gen_to_be_invoked.StartCoroutine( _routine );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopCoroutine(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                IFramework.Modules.Coroutine.CoroutineModule gen_to_be_invoked = (IFramework.Modules.Coroutine.CoroutineModule)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    IFramework.Modules.Coroutine.ICoroutine _routine = (IFramework.Modules.Coroutine.ICoroutine)translator.GetObject(L, 2, typeof(IFramework.Modules.Coroutine.ICoroutine));
                    
                    gen_to_be_invoked.StopCoroutine( _routine );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
