using UnityEngine;

[CreateAssetMenu(fileName = "StickSO", menuName = "Scriptable Objects/StickSO")]
public class StickSO : ScriptableObject
{
    [SerializeField] public int size = 2;
    [SerializeField] public StickType stickType;

}
