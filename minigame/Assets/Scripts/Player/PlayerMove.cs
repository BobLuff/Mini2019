using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private Animator animator;

    public float playerMoveV=50f;
    public float FallVelocity = 10f;


    private bool isFacingRight = true;                        //是否朝向为右 
    public Transform nextlevel_p;
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
            if (isFacingRight)
            {
                FlipX();

            }
            animator.SetBool("idle", false);
            animator.SetBool("walk", true);
            transform.position += new Vector3(-1.0f,0f,0f)*Time.deltaTime*playerMoveV;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if(!isFacingRight)
            {
                FlipX();
            }
            animator.SetBool("idle", false);
            animator.SetBool("walk", true);
            transform.position += new Vector3(1.0f, 0f, 0f) * Time.deltaTime*playerMoveV;
        }
        else
        {
            animator.SetBool("walk", false);
            animator.SetBool("idle", true);
        }
        //玩家降落速度超过X——>执行
       if (this.GetComponent<Rigidbody2D>().velocity.y > -FallVelocity)
        {
            
           // this.gameObject.transform.position = new Vector3(707f, 328f, 0f);
        }
        
    }



    /// <summary>
    /// player左右翻转
    /// </summary>
    private void FlipX()
    {
        // Switch the way the player is labelled as facing.转变朝向标签
        isFacingRight = !isFacingRight;

        // Multiply the player's x local scale by -1.尺寸x轴乘以`-（负号）`
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "nextlevel")
        {
           // Destroy(this.gameObject);
            this.gameObject.transform.position =nextlevel_p.position;
        }
    }


   

}
