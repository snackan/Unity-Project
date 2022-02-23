using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Hela den h�r koden �r gjord av Mickael 
     // det h�r �r det som min kod revolverar kring
     
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
    // Dem ovanf�r �r variablar jag s�tter sj�lvaste koden till karakt�rens r�relse. och i unity best�mmer hur snabbt gubben g�r och vilka knappar som varje r�relse h�r till.
    bool isGrounded = true;
    [SerializeField]
    private float jumpForce;
    private Rigidbody2D rb;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    // Dem ovanf�r h�r �r f�r att s�ga vad som �r mark hur starkt hoppet ska vara och positionen p� gubben som marken kommer i kontakt med.
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
    // Dem ovanf�r h�r �r f�r att kolla hur l�nge hoppet ska ske, n�r gubben hoppar, ett st�lle att setta koden f�r animationerna och r�kna tiden det tar att hoppa.
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
           // den h�r koden flyttar spelaren till den position som beffiner sig i -y.
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        if (Input.GetKey(left))
        {
            // Den h�r koden startar en animation n�r spelarens position �r mot x och hastighet �ver noll.
            m_Animator.SetFloat("walking speed", speed);
            // den h�r koden flyttar spelaren till den position som beffiner sig i -x.
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        else if (Input.GetKey(right))
        {
            // Den h�r koden startar en animation n�r spelarens position �r mot x och hastighet �ver noll.
            m_Animator.SetFloat("walking speed", speed);
            // den h�r koden flyttar spelaren till den position som beffiner sig i x.
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej Mickael");
        }
        else
        {
            m_Animator.SetFloat("walking speed", 0);// Den h�r koden startar en animation n�r spelarens hastighet �r �ver noll.
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space)) // Den h�r kollar om spelaren �r p� marken om den �r s� ska man kunna man kunna trycka p� space f�r att hoppa.
        {
            print("ground jump");
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true) /* Den h�r koden ser till s� att n�r spelaren trycker p� space och inte h�ller ner space
                                                               s� blir det ett kortare hopp och den ser ocks� till s� att det inte funkar i luften.*/
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
