using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Reset()
    {
        this.LoadComponent();
        this.ResetValue();

    }
    protected virtual void LoadComponent()
    {
        // to do overide
    }
    protected virtual void ResetValue()
    {
        // to do overide
    }
}
