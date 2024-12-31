using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.iOS;

public class GameManager : MonoBehaviour
{
    public Cube cube;
    public Stick stick;
    Vector2 startPos;
    Vector2 endPos;
    Vector2 dir;
    

    private RaycastHit raycastHit;
    private bool choosingStick;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            if (isPointerOnStick() != null)
            {
                choosingStick = true;
                stick = isPointerOnStick();
            } else
            {
                choosingStick = false;   
            }
        }
        
        if (Input.GetMouseButton(0)) 
        {
            endPos = Input.mousePosition;
            dir = endPos - startPos;
            startPos = endPos;
            if (!choosingStick)
            {
                cube.Rotation(dir.normalized);
            } else
            {
                stick.UpdatePosition(dir);
            }
            
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            cube.Stop();
        }
        
    }
    Stick isPointerOnStick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out raycastHit))
        {
            return raycastHit.transform.GetComponent<Stick>();
        }
        else
        {
            return null;
        }
    }
}
