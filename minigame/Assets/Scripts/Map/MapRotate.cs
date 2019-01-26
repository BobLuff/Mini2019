using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotate : MonoBehaviour
{
    public float mapRotateV=40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f,0f,Time.deltaTime*mapRotateV,Space.Self);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, Time.deltaTime * -mapRotateV, Space.Self);
        }
    }
}
