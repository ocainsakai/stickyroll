using Unity.Mathematics;
using UnityEngine;

public class StickHeight : StickAbstract
{
    [SerializeField] protected float _height;
    public float Height => _height;
}
