using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    // DashMove koden ar gjord av Mickael men jag fick lite hj?lp av Olle.
    private Rigidbody2D rb;

    public float dashSpeed;
    private float dashtTime;
    public float startDashTime;
    private int direction;

    public float speed;
    // det h?r ?r variablarna som jag s?tter farten p? dashen kollar dem olika h?llen dashen g?r och startar dashen.
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashtTime = startDashTime;
    } // den h?r i princip startar dashen

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direction = 1;
                dashtTime = startDashTime;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                direction = 2;
                dashtTime = startDashTime;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                direction = 3;
                dashtTime = startDashTime;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                direction = 4;
                dashtTime = startDashTime;
            }

        }
        if (dashtTime <= 0)
        {
            direction = 0;
            dashtTime = startDashTime;
            //rb.velocity = Vector2.zero;
        }
       /* else
        {
            dashtTime -= Time.deltaTime;

            if (direction == 1)
            {
                rb.velocity = Vector2.left * dashSpeed;
            }
            else if (direction == 2)
            {
                rb.velocity = Vector2.right * dashSpeed;
            }
            else if (direction == 3)
            {
                rb.velocity = Vector2.up * dashSpeed;
            }
            else if (direction == 4)
            {
                rb.velocity = Vector2.down * dashSpeed;
            }
        } */

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5;
          mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 difference = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            rb.velocity = -difference.normalized * speed;
        }
        // Den h?r koden kollar musens position och skuter spelaren ?t motsat h?ll n?r man h?gerklickar.
        
    }
}
