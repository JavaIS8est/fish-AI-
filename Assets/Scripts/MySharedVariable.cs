using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;

[System.Serializable]
public class MySharedValue
{
    // 在这里添加自定义变量
    public int id = 0;
    public string name = string.Empty;
    public GameObject go;
    // ...
}

[System.Serializable]
public class MySharedVariable : SharedVariable<MySharedValue>
{
	public override string ToString() { return mValue == null ? "null" : mValue.ToString(); }
	public static implicit operator MySharedVariable(MySharedValue value) { return new MySharedVariable { mValue = value }; }
}