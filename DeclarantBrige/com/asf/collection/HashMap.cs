using System.Collections.Generic;

namespace com.asf.collection {

    /// <summary>
    /// java like колелекция
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    class HashMap<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public new void Add(TKey key, TValue value)
        {
            if(ContainsKey(key))
            {
                base[key] = value;
            }
            else
            {
                base.Add(key, value);
            }
        }
    }
}
