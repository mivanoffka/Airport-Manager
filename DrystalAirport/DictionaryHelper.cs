using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrystalAirport
{
    public static class DictionaryHelper
    {

        public static List<string> GetValues(List<KeyValuePair<int, string>> keyValuePairs)
        {
            List<string> values = new List<string>();

            foreach (var pair in keyValuePairs)
            {
                values.Add(pair.Value);
            }

            return values;
        }

        public static string GetValue(List<KeyValuePair<int, string>> keyValuePairs, int key)
        {
            foreach (var pair in keyValuePairs)
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }

            return null;
        }

        public static int GetKey(List<KeyValuePair<int, string>> keyValuePairs, string value)
        {
            foreach (var pair in keyValuePairs)
            {
                if (pair.Value == value)
                {
                    return pair.Key;
                }
            }

            return -1;
        }

        public static List<int> GetKeys(List<KeyValuePair<int, string>> keyValuePairs)
        {
            List<int> keys = new List<int>();

            foreach (var pair in keyValuePairs)
            {
                keys.Add(pair.Key);
            }

            return keys;
        }
    }
}
