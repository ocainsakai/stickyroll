using System.Collections;
using UnityEngine;

public class StickRotaiton : MonoBehaviour
{
    public void Rotation(float angle)
    {

        this.transform.parent.Rotate(0, angle, 0);
    }
    public void Start()
    {
        Test();
    }
    public void Test()
    {
        //StartCoroutine(RotateOverTime(90f,2f));
        Debug.Log("Rotation" + this.name);
        //Invoke(nameof(this.Test), 3f);
    }
    //IEnumerator RotateOverTime(float offsetAmout, float duration)
    //{
    //    float startAngle = transform.parent.eulerAngles.y;
    //            float targetAngle = startAngle + offsetAmout;

    //    float timeElapsed = 0;

    //    while (timeElapsed < duration)
    //    {
    //        float newAngle = Mathf.Lerp(startAngle, targetAngle, timeElapsed / duration);
    //        transform.parent.rotation = Quaternion.Euler(0, newAngle, 0);
    //        timeElapsed += Time.deltaTime;
    //        yield return null;
    //    }
    //    Rotation(targetAngle);
    //}

}
