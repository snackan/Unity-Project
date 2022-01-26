using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject Bullet;

    public float rotation;
    public Vector3 direction;

    public float movementTimer;
    public bool doMove;
    public string playerSide;
    public string chosenAttack;

    // Start is called before the first frame update
    void Start()
    {
        //play sound "boss start"?

        movementTimer = 0;
        chosenAttack = "none";

    }

    // Update is called once per frame
    void Update()
    {
        if (doMove == true && movementTimer > 0 && chosenAttack == "charge")
        {
            movementTimer -= Time.deltaTime;

            if (movementTimer > 0 && movementTimer < 1)
            {


                if (playerSide == "right")
                {
                    transform.position += new Vector3(6, 0, 0) * Time.deltaTime;
                }
                else if (playerSide == "left")
                {
                    transform.position += new Vector3(-6, 0, 0) * Time.deltaTime;

                }
            }
            else
            {



                if (playerSide == "right")
                {
                    transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;
                }
                else if (playerSide == "left")
                {
                    transform.position += new Vector3(2, 0, 0) * Time.deltaTime;

                }

            }


        }
        else if (doMove == true && movementTimer > 0 && chosenAttack == "shoot")
        {

            movementTimer = .5f;
            doMove = false;

            direction = new Vector3(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y+1, 0);
            direction.Normalize();
            rotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Instantiate(Bullet, transform.position - new Vector3(0, 1, 0), Quaternion.Euler(0, 0, rotation));        
        }
        else
        {
            if (movementTimer < 0)
            {
                doMove = false;
                chosenAttack = "none";
                movementTimer = 0.1f;

                

            }
            if (movementTimer > 2f)
            {

                doMove = true;



                if (Player.transform.position.x > transform.position.x)
                {
                    playerSide = "right";
                }
                else
                {
                    playerSide = "left";
                }

                if (playerSide == "right")

                { 
                    if (transform.position.x + 6 < Player.transform.position.x)
                    {
                        chosenAttack = "shoot";
                    }
                    else
                    {
                        chosenAttack = "charge";
                    }
                }

                if (playerSide == "left" )
                {
                    if(transform.position.x - 6 > Player.transform.position.x)
                    {
                        chosenAttack = "shoot";

                    }
                    else
                    {
                        chosenAttack = "charge";
                    }
                }
                
            }

            movementTimer += Time.deltaTime / 2;



        }
    }
}
