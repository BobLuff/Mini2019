using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneShake : MonoBehaviour
{
    //抖动角度范围
    public float minimum = -5.0F;
    public float maximum = 5.0F;
    static float t = 0.0f;
    //抖动速度
    public float shakeV=5f;
    private bool ifshake=true;
    void Update()
    {
        if(ifshake)
            phoneshake();   
    }

    void phoneshake()
    {
        transform.eulerAngles = new Vector3(0, 0, Mathf.Lerp(minimum, maximum, t));

        t += shakeV * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
    public void stopshake()
    {
        ifshake = false;
    }
   
}
