using System;
using System.Collections.Generic;

namespace Solvtio.Common
{
    public class KeyValue
    {
        #region Constructors

        public KeyValue() { }
        public KeyValue(string key) : this()
        {
            Key = key;
        }
        public KeyValue(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public KeyValue(int key, string value)
        {
            KeyInt = key;
            Key = key.ToString();
            Value = value;
        }
        public KeyValue(int keyInt, string keyStr, string value)
        {
            KeyInt = keyInt;
            Key = keyStr;
            Value = value;
        }

        #endregion

        #region Properties

        public string Key { get; set; }
        public int KeyInt { get; set; }
        public string Value { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public DateTime? ValueDate1 { get; set; }

        public int? ValueInt1 { get; set; }
        public int? ValueInt2 { get; set; }
        public int? ValueInt3 { get; set; }
        public int? ValueInt4 { get; set; }

        #endregion

        public static IList<KeyValue> GetSomeKeyValueToTest(int cantidad = 10)
        {
            var result = new List<KeyValue>();

            for (var i = 0; i < cantidad; i++)
            {
                result.Add(new KeyValue($"key {i}", $"value for test {i}"));
            }

            return result;
        }

    }

}
