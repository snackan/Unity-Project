using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    
    [SerializeField, Range(1, 10)]
    float speed;
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    bool isGrounded = true;
    [SerializeField]
    private float jumpForce;
    private Rigidbody2D rb;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    [SerializeField]
    private float jumpTimeCounter;
    [SerializeField]
    public float jumpTime;
    private bool isJumping;
    Animator m_Animator;
    [SerializeField]
    GameObject rotateFocus;
    public Animator animator;
    public float runSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_Animator = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // horizantolMove = Input.GetAxisRaw
        if (Input.GetKey(down))
        {
           
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        if (Input.GetKey(left))
        {

            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        if (Input.GetKey(right))
        {

            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            print("ground jump");
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {


            if (jumpTimeCounter > 0)
            {
                print("continue jump");
                m_Animator.SetTrigger("Jump");
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                print("nej jump");
                isJumping = false;
            }
        }
        else
        {
            isJumping = false;
        }
       // Animator.SetFloat("walking speed", )
            

        

        
    }
}
