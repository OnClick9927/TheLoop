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
    public class IFrameworkTweensTweenExWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.Tweens.TweenEx);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRecyle", _m_SetRecyle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OnCompelete", _m_OnCompelete_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLoop", _m_SetLoop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAnimationCurve", _m_SetAnimationCurve_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetEase", _m_SetEase_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetUpdateType", _m_SetUpdateType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDeltaTime", _m_SetDeltaTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDelta", _m_SetDelta_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTimeScale", _m_SetTimeScale_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.Tweens.TweenEx does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRecyle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    bool _rec = LuaAPI.lua_toboolean(L, 2);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetRecyle( _tween, _rec );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnCompelete_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    System.Action _onCompelete = translator.GetDelegate<System.Action>(L, 2);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.OnCompelete( _tween, _onCompelete );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLoop_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    int _loop = LuaAPI.xlua_tointeger(L, 2);
                    IFramework.Tweens.LoopType _loopType;translator.Get(L, 3, out _loopType);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetLoop( _tween, _loop, _loopType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAnimationCurve_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    UnityEngine.AnimationCurve _curve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetAnimationCurve( _tween, _curve );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEase_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    IFramework.Tweens.Ease _ease;translator.Get(L, 2, out _ease);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetEase( _tween, _ease );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUpdateType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    IFramework.Tweens.TweenUpdateType _type;translator.Get(L, 2, out _type);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetUpdateType( _tween, _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDeltaTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    float _delta = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetDeltaTime( _tween, _delta );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDelta_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    float _delta = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetDelta( _tween, _delta );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTimeScale_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    IFramework.Tweens.ITween _tween = (IFramework.Tweens.ITween)translator.GetObject(L, 1, typeof(IFramework.Tweens.ITween));
                    float _speed = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        IFramework.Tweens.ITween gen_ret = IFramework.Tweens.TweenEx.SetTimeScale( _tween, _speed );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
