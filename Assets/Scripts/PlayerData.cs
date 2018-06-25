using UnityEngine;
using BehaviorDesigner.Runtime;

[System.Serializable]
public class PlayerData : SharedVariable<Player>
{
	public override string ToString() { return mValue == null ? "null" : mValue.ToString(); }
	public static implicit operator PlayerData(Player value) { return new PlayerData { mValue = value }; }
}