using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNPC : MonoBehaviour
{
    [Tooltip("移动速度")]
    public float MaxSpeed = 1;//移动速度
    public Transform rightMove;//右侧移动边界
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x <= rightMove.position.x)
        {
            transform.position += new Vector3(1.0f, 0f, 0f) * Time.deltaTime * MaxSpeed;
        }
    }
}
