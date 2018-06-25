using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;

public class Player : MonoBehaviour {

    public int id;
    public int life;
    public ExternalBehaviorTree exbehaviorTree;  //外部行为树
    public MySharedValue mySharedData; //可以在Inspector中初始化共享数值
    BehaviorTree tree;
    void Start () {
        tree = this.gameObject.AddComponent<BehaviorTree>();  // 手工添加行为树
        tree.StartWhenEnabled = false; // 设置为默认关闭行为树
        tree.RestartWhenComplete = true;
        tree.PauseWhenDisabled = false;  // gameObject无效时，如果设为False，暂停btree任务，否则直接终止btree任务
        tree.ExternalBehavior = exbehaviorTree;  // 获取外部行为树
        
        tree.SetVariableValue("PlayerData", this); 
        tree.SetVariableValue("MyShared", mySharedData);  // 设置共享变量
        //...
        tree.EnableBehavior(); // 手工启动行为树
        tree.CheckForSerialization();  // 检查行为树是否进行了初始化
    }

    // Update is called once per frame
    void Update()
    {
       
        //tree.SendEvent("Hit");  // 发送事件给 Has Received Event 任务
    }
}
