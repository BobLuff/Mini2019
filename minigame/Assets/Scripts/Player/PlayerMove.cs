using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerMoveV=50f;
    public float FallVelocity = 10f;
    public Sprite grow1;
    private bool changea=false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //控制Player移动
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1.0f,0f,0f)*Time.deltaTime*playerMoveV;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1.0f, 0f, 0f) * Time.deltaTime*playerMoveV;
        }
        //玩家降落速度超过X——>执行
       if (this.GetComponent<Rigidbody2D>().velocity.y > -FallVelocity)
        {
            
           // this.gameObject.transform.position = new Vector3(707f, 328f, 0f);
        }
        //控制Sprite不透明度
        if (changea)
        {
            this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, -0.05f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "nextlevel")
        {
           // Destroy(this.gameObject);
            this.gameObject.transform.position =new Vector3(707f,328f,0f);
        }
        if (collision.tag == "grow1")
        {
            changea = true;
          
        }
    }
   

}
