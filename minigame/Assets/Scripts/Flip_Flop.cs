using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flip_Flop : MonoBehaviour {

    public UnityEvent Touch;
    public UnityEvent Disappeart;
    [Header("对象标签名称")]
    public string Tagname;
    [Header("是否过段时间调用Disappert")]
    public bool cover=true;
    [Header("调用等待时间")]
    public float time = 5;
    public UnityEvent P_Touch;
    public UnityEvent P_Disappeart;
    [Header("粒子名称")]
    public string P_Tagname;
    [Header("是否过段时间调用P_Disappert")]
    public bool P_cover = true;
    [Header("调用等待时间")]
    public float P_time = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tagname))
        {
            Touch.Invoke();
            Debug.Log(1);
            if (cover)
            {
                StartCoroutine(start_Disappeart());
            }

        }

    }


    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("touch");
    //    if (collision.gameObject.CompareTag(Tagname))
    //    {
    //        Touch.Invoke();
    //        Debug.Log("tag");
    //        if (cover)
    //        {
    //            StartCoroutine(start_Disappeart());
    //        }

    //    }
    //}

    IEnumerator start_Disappeart()
    {
        yield return new WaitForSeconds(time);
        Disappeart.Invoke();
    }



    void OnParticleCollision(GameObject obj)
    {
        Debug.Log("P_touch");
        if (obj.CompareTag(P_Tagname))
        {
            P_Touch.Invoke();
            Debug.Log("P_tag");
            if (cover)
            {
                StartCoroutine(start_P_Disappeart());
            }

        }
    }

    IEnumerator start_P_Disappeart()
    {
        yield return new WaitForSeconds(time);
        P_Disappeart.Invoke();
    }
}
