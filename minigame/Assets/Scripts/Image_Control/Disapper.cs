using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disapper : MonoBehaviour
{
    [Header("持续时间")]
    public float timer = 5f;


    public void Start()
    {
        this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, -0.1f);
        Destroy(gameObject, timer);
    }

}
