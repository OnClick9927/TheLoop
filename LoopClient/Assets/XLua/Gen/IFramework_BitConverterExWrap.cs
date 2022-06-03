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
    public class IFrameworkBitConverterExWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(IFramework.BitConverterEx);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 17, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "BytesToHexString", _m_BytesToHexString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HexStringToBytes", _m_HexStringToBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToInt16", _m_ToInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToInt32", _m_ToInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToInt64", _m_ToInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToUInt16", _m_ToUInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToUInt32", _m_ToUInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToUInt64", _m_ToUInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToSingle", _m_ToSingle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToDouble", _m_ToDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToDecimal", _m_ToDecimal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToGuid", _m_ToGuid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToSByte", _m_ToSByte_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToBoolean", _m_ToBoolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToChar", _m_ToChar_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBytes", _m_GetBytes_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "IFramework.BitConverterEx does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BytesToHexString_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    bool _lower = LuaAPI.lua_toboolean(L, 2);
                    
                        string gen_ret = IFramework.BitConverterEx.BytesToHexString( _bytes, _lower );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    
                        string gen_ret = IFramework.BitConverterEx.BytesToHexString( _bytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.BitConverterEx.BytesToHexString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HexStringToBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _hex = LuaAPI.lua_tostring(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.HexStringToBytes( _hex );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        short gen_ret = IFramework.BitConverterEx.ToInt16( _buffer, _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = IFramework.BitConverterEx.ToInt32( _buffer, _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        long gen_ret = IFramework.BitConverterEx.ToInt64( _buffer, _offset );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort gen_ret = IFramework.BitConverterEx.ToUInt16( _buffer, _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = IFramework.BitConverterEx.ToUInt32( _buffer, _offset );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        ulong gen_ret = IFramework.BitConverterEx.ToUInt64( _buffer, _offset );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToSingle_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        float gen_ret = IFramework.BitConverterEx.ToSingle( _buffer, _offset );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        double gen_ret = IFramework.BitConverterEx.ToDouble( _buffer, _offset );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDecimal_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        decimal gen_ret = IFramework.BitConverterEx.ToDecimal( _buffer, _offset );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToGuid_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.Guid gen_ret = IFramework.BitConverterEx.ToGuid( _buffer, _offset );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToSByte_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        sbyte gen_ret = IFramework.BitConverterEx.ToSByte( _bytes, _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToBoolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = IFramework.BitConverterEx.ToBoolean( _buffer, _offset );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToChar_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    
                        char gen_ret = IFramework.BitConverterEx.ToChar( _buffer, _offset );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    sbyte _value = (sbyte)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    char _value = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    short _value = (short)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isuint64(L, 1))) 
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || translator.IsDecimal(L, 1))) 
                {
                    decimal _value;translator.Get(L, 1, out _value);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.Guid>(L, 1)) 
                {
                    System.Guid _value;translator.Get(L, 1, out _value);
                    
                        byte[] gen_ret = IFramework.BitConverterEx.GetBytes( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to IFramework.BitConverterEx.GetBytes!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
