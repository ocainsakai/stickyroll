using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
[ExecuteInEditMode]
public class Stick : MonoBehaviour
{
    [Range(1f, 5f)]
    public float height;
    public float maxPosition;
    public void UpdateHeight(float height)
    {
        UpdateRotation();
        float dif = (height - transform.localScale.y);
        transform.localScale =  new Vector3 (transform.localScale.x,height,transform.localScale.z);
    }

    public void UpdatePosition(Vector3 vector)
    {
        Vector3 force = Vector3.Project (vector, transform.up);
        
        transform.position += force.normalized;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
  
    void UpdateRotation()
    {
        transform.up = transform.parent.up;
    }
    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            UpdateHeight(height);

        }
       
    }

  
}
