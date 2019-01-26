using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 销毁物体
/// </summary>
public class ComeOut : MonoBehaviour {
    [Header("持续时间")]
    public float timer = 5f;


    public void Start()
    {
        this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, +0.05f);
        Destroy(gameObject, timer);
    }

}
