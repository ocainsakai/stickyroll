using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Cube : MonoBehaviour
{
    List<StickFace> stickFaces;
    Rigidbody rb => GetComponent<Rigidbody>();
    private float rotationSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stickFaces = new List<StickFace>(GetComponentsInChildren<StickFace>());
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Rotation(Vector2 dir)
    {
        Vector2 axis = new Vector2(dir.y, -dir.x);
        rb.angularVelocity = axis * rotationSpeed;
    }
    public void Stop()
    {
        rb.angularVelocity = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
    }
}
