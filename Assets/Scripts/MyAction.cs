using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

[BehaviorDesigner.Runtime.Tasks.TaskCategory("MyGame")]
public class MyAction : Action
{
    public int id = 0;
    public override void OnAwake()
    {
        MySharedVariable shared = (MySharedVariable)Owner.GetVariable("MyShared");
        MySharedValue v = (MySharedValue)shared.Value;
        v.id = 100;

        PlayerData playerData = (PlayerData)Owner.GetVariable("PlayerData");
        Player player = (Player)playerData.Value;
        player.life = 10;
    }


    public override TaskStatus OnUpdate()
	{
		return TaskStatus.Success;
	}
}