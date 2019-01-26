using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 触发父物体的上升，需放在子物体中
/// </summary>
public class PlatformUp : MonoBehaviour {
    [Header("移动速度")]
    public float speed = 2;
    [Header("上升边界")]
    public Transform up;
    [Header("下降边界")]
    public Transform down;
    [Header("左边界")]
    public Transform left;
    [Header("右边界")]
    public Transform right;
    //[Header("上界停止位置")]
    //public Transform up_stop;
    //[Header("下界停止位置")]
    //public Transform down_stop;

    void FixedUpdate()
    {
        if (up) {
            if (this.gameObject.transform.position.y < up.transform.position.y)
            {
                this.gameObject.transform.parent.gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        if (down) {
            if (this.gameObject.transform.position.y > down.transform.position.y)
            {
                this.gameObject.transform.parent.gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
        if (left)
        {
            if (this.gameObject.transform.position.x > left.transform.position.x)
            {
                this.gameObject.transform.parent.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        if (right)
        {
            if (this.gameObject.transform.position.x < right.transform.position.x)
            {
                this.gameObject.transform.parent.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
        //if (down_stop)
        //{
        //    if (this.transform.position.y <= down_stop.position.y)
        //    {
        //        this.gameObject.transform.parent.gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        //    }
        //}
    }
        
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
