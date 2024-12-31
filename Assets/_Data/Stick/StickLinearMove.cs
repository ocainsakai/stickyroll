using UnityEngine;

public class StickLinearMove : MonoBehaviour
{
    public void LinearMove(float y)
    {
        transform.parent.position += new Vector3(0,y,0);
    }
}
