using System.Collections.Generic;

class MyDictionary<TKey,TValue>
{
    public int Count { get; set;}
    TKey[] keyList;
    TValue[] valueList;
    TKey[] tempKeyList;
    TValue[] tempValueList;

    public MyDictionary()
    {
        keyList = new TKey[0];
        valueList = new TValue[0];
    }

    public void Add(TKey key, TValue value){
        tempKeyList = keyList;
        tempValueList = valueList;
        keyList = new TKey[keyList.Length+1];
        valueList = new TValue[valueList.Length+1];

        for (int i = 0; i < tempKeyList.Length; i++)
        {
            keyList[i] = tempKeyList[i];
        }
        for (int i = 0; i < tempValueList.Length; i++)
        {
            valueList[i] = tempValueList[i];
        }
        keyList[keyList.Length-1] = key;
        valueList[valueList.Length-1] = value;
    }
    public void GetAll(){
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();
        foreach (TKey key in keyList)
        {
            keys.Add(key);
        }
        foreach (TValue value in valueList)
        {
            values.Add(value);
        }
        for (int i = 0; i < keys.Count; i++)
        {
            System.Console.WriteLine(keys[i] + " - " + values[i]);
        }
        this.Count = keys.Count;
    }
}