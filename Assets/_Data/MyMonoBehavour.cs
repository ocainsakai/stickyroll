using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
        this.ResetValue();

    }
    protected virtual void LoadComponents()
    {
        // to do overide
    }
    protected virtual void ResetValue()
    {
        // to do overide
    }
}
