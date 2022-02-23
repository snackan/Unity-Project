using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Hela den här koden är gjord av Mickael 
     // det här är det som min kod revolverar kring
     
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
    // Dem ovanför är variablar jag sätter självaste koden till karaktärens rörelse. och i unity bestämmer hur snabbt gubben går och vilka knappar som varje rörelse hör till.
    bool isGrounded = true;
    [SerializeField]
    private float jumpForce;
    private Rigidbody2D rb;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    // Dem ovanför här är för att säga vad som är mark hur starkt hoppet ska vara och positionen på gubben som marken kommer i kontakt med.
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
    // Dem ovanför här är för att kolla hur länge hoppet ska ske, när gubben hoppar, ett ställe att setta koden för animationerna och räkna tiden det tar att hoppa.
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
           // den här koden flyttar spelaren till den position som beffiner sig i -y.
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        if (Input.GetKey(left))
        {
            // Den här koden startar en animation när spelarens position är mot x och hastighet över noll.
            m_Animator.SetFloat("walking speed", speed);
            // den här koden flyttar spelaren till den position som beffiner sig i -x.
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        else if (Input.GetKey(right))
        {
            // Den här koden startar en animation när spelarens position är mot x och hastighet över noll.
            m_Animator.SetFloat("walking speed", speed);
            // den här koden flyttar spelaren till den position som beffiner sig i x.
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        else
        {
            m_Animator.SetFloat("walking speed", 0);// Den här koden startar en animation när spelarens hastighet är över noll.
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space)) // Den här kollar om spelaren är på marken om den är så ska man kunna man kunna trycka på space för att hoppa.
        {
            print("ground jump");
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true) /* Den här koden ser till så att när spelaren trycker på space och inte håller ner space
                                                               så blir det ett kortare hopp och den ser också till så att det inte funkar i luften.*/
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
