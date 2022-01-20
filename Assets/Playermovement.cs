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
    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    Animator m_Animator;
    [SerializeField]
    GameObject rotateFocus;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(down))
        {
           
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        if (Input.GetKey(left))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        if (Input.GetKey(right))
        {
            rotateFocus.transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej mamma");
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)


            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("Jump");
        }



        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Reset the "Jump" trigger
            m_Animator.ResetTrigger("Jump");

            
        }
    }
}
