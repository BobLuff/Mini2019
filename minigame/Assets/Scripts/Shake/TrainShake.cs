using UnityEngine;

public class TrainShake : MonoBehaviour
{
    //火车抖动范围
    public float minimum = -0.5F;
    public float maximum = 0.5F;
 
    static float t = 0.0f;

    //火车抖动速度
    public float shakev=5f;

    //控制抖动频率
    public float shakeRate=1.0f;
    private float currentrate=1.0f;
    void Update()
    {
        currentrate -= Time.deltaTime;
        if (currentrate<0)
        {
            shakethetrain();
            Invoke("setrate",2f);
            
        }
    }
    void shakethetrain()
    {
        transform.position = new Vector3(0, Mathf.Lerp(minimum, maximum, t), 0);
        t += shakev * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
    void setrate()
    {
        currentrate=shakeRate;
    }
}