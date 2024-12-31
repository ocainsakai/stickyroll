using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[ExecuteInEditMode]
public class StickFace : MonoBehaviour
{
    public int size = 2;
    private List<Stick> listOfStick => new List<Stick>(GetComponentsInChildren<Stick>());
    private 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateStick();
    }
    void UpdateStick()
    {
        Vector3 initialDir = transform.forward + transform.right;
        for (int i = 0; i < listOfStick.Count; i++)
        {
            Stick stick = listOfStick[i];
            stick.transform.position = Quaternion.AngleAxis(90*i, transform.up) * initialDir + transform.up * (stick.height - size*2);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
