using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey ID,TValue Book)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = ID;
            values[values.Length - 1] = Book;
        }

        public int Length { get { return keys.Length; } }
        public TValue[] Items { get { return values; } }
    }
}
