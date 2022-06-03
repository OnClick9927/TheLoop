/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using System.Collections.Generic;
using UnityEngine;
using IFramework.Serialization;
namespace LoopClient
{
    public class LoopClientPerfs
    {
        private static Dictionary<string, string> _perfs = new Dictionary<string, string>();
        private static string key = "LoopClientPerfs465465";
        public static void SetKey(string key)
        {
            LoopClientPerfs.key = key;
            Init();
        }
        private static void Init()
        {
            var value = PlayerPrefs.GetString(key);
            if (!string.IsNullOrEmpty(value))
            {
                StringConvert.TryConvert(value, out _perfs);
            }
        }
        public static void Save(string key, string value)
        {
            if (_perfs.ContainsKey(key))
            {
                _perfs[key] = value;
            }
            else
            {
                _perfs.Add(key, value);
            }
            Save();
        }
        public static string Read(string key)
        {
            if (_perfs.ContainsKey(key))
            {
                return _perfs[key];
            }
            return string.Empty;
        }

        public static void Save<T>(string key, T Obj) where T : class, new()
        {
            Save(key, StringConvert.ConvertToString(Obj));
        }
        public static T Read<T>(string key) where T : class, new()
        {
            var str = Read(key);
            if (string.IsNullOrEmpty(str))
            {
                return default;
            }
            T Obj;
            StringConvert.TryConvert<T>(str, out Obj);
            return Obj;
        }
        public static void Save()
        {
            var str = StringConvert.ConvertToString(_perfs);
            PlayerPrefs.SetString(key, str);
        }
    }
}
