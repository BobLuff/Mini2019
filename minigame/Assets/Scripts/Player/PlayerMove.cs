using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private Animator animator;

    public float playerMoveV=50f;
    public float FallVelocity = 10f;
    private Vector3 targetPositon;

    [SerializeField]
    private MapRotate[] mapRotates;
    private MapRotate curMap;
    private int curMapIndex = 0;

    private bool isFacingRight = true;                        //是否朝向为右 
    public Transform nextlevel_p_1;
    public Transform nextlevel_p_2;
    public Transform nextlevel_p_3;
    public Transform nextlevel_p_4;
    public Transform nextlevel_p_5;
    public Transform nextlevel_p_6;
    // Start is called before the first frame update
    void Start()
    {
        curMap = mapRotates[curMapIndex];
        curMap.isRoutateMap = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit;

        int Rmask = LayerMask.GetMask("Platform");


        Debug.DrawRay(transform.position, Vector2.down, Color.green);
        hit = Physics2D.Raycast(transform.position, Vector2.down, 10.0f, Rmask);
        if (hit)
        {
            targetPositon = hit.point;
            targetPositon.z = transform.position.z;

        }
        Vector3 dir = transform.position - targetPositon;
        //z的值保持不变，只在xy方向上进行旋转
        dir.z = transform.position.z;
        //点乘计算两个向量的夹角，及角色和目标点的夹角(本人的项目中-up轴是正方向)
        float dotValue = Vector3.Dot(-Vector2.down, dir.normalized);
        //获得夹角值
        float angle = Mathf.Acos(dotValue) * Mathf.Rad2Deg;
        //用叉乘判断两个向量是否同方向
        Vector3 tempDir = Vector3.Cross(Vector2.down, dir.normalized);
        if (tempDir.z < 0)//说明两个向量方向相反，这个判断用来确定假如两个之间夹角30度 到底是顺时 还是逆时针旋转。
        {
            angle = angle * (-1);
        }
        transform.RotateAround(transform.position, Vector3.forward, angle);



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
        if (collision.tag == "nextlevel1")
        {
            curMap.isRoutateMap = false;
            curMapIndex++;
            curMap = mapRotates[curMapIndex];
            curMap.isRoutateMap = true;
           // Destroy(this.gameObject);
            this.gameObject.transform.position =nextlevel_p_1.position;
        }
        if (collision.tag == "nextlevel2")
        {
            // Destroy(this.gameObject);
            this.gameObject.transform.position = nextlevel_p_2.position;
        }
        if (collision.tag == "nextlevel3")
        {
            // Destroy(this.gameObject);
            this.gameObject.transform.position = nextlevel_p_3.position;
        }
        if (collision.tag == "nextlevel4")
        {
            // Destroy(this.gameObject);
            this.gameObject.transform.position = nextlevel_p_4.position;
        }
        if (collision.tag == "nextlevel15")
        {
            // Destroy(this.gameObject);
            this.gameObject.transform.position = nextlevel_p_5.position;
        }
        if (collision.tag == "nextlevel6")
        {
            // Destroy(this.gameObject);
            this.gameObject.transform.position = nextlevel_p_6.position;
        }
    }


   

}
