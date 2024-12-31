using UnityEngine;

public abstract class StickAbstract : MyMonoBehaviour
{
    [SerializeField] protected StickCtrl _stickCtrl;
    public StickCtrl stickCtrl => _stickCtrl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadStickCtrl();
    }
    protected virtual void LoadStickCtrl()
    {
        if (stickCtrl != null) return;
        this._stickCtrl = transform.parent.GetComponent<StickCtrl>();
        Debug.LogWarning(transform.name + "LoadStickCtrl", gameObject);
    }
}
