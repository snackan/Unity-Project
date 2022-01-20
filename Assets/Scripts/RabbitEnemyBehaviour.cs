using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitEnemyBehaviour : MonoBehaviour
{

    //get the player and bullet objects to refference them later
    Playermovement player;

    [SerializeField]
    GameObject Bullet;

    HealthPickup heart;

    public float rotation;
    public Vector3 direction;

    //used to check when the next jump will be and for how long the enemy will move when jumping
    public float movementTimer;

    //is the enemy allowed to move or not
    public bool doMove;

    //which side the player is of the enemy
    public string playerSide;

    //after how many jumps the enemy gets to shoot
    public int shootCounter = 3;


    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {
        //makes it so the enemy have to wait a bit before making its first movement
        movementTimer = 0;

        player = FindObjectOfType<Playermovement>();
        heart = FindObjectOfType<HealthPickup>();


    }

    // Update is called once per frame
    void Update()
    {

        //how this enemies movement works is that normally a timer is ticking up and when it reaches a certain threshold it quickly counts back down to 0, rince and repear
        //before the enemy gets to move, it checkes which side the player is on in relation to itself, this makes it so if the player jumps over the enemy the enemy doesnt immediately turn around
        //while the counter is decreasing the enemy gets to move immitating a "jump"
        //at the end of the jump (when the timer reaches 0 and starts countng up again), shootcounter is reduced by 1
        //if shootCounter = 0 then the enemy fires a projectile towards the player and shootCounter is set to 3

        if (doMove == true && movementTimer > 0)
        {
            movementTimer -= Time.deltaTime;
            if (playerSide == "right")
            {
                transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
            }
            else if (playerSide == "left")
            {
                transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;

            }

            
        }
        else
        {
            if (movementTimer < 0)
            {
                doMove = false;
                movementTimer = 0.1f;

                shootCounter -= 1;

                if (shootCounter == 0)
                {

                    Instantiate(Bullet, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
                    shootCounter = 3;
                }

            }
            if (movementTimer > 0.5f)
            {
                doMove = true;

                if (player.transform.position.x > transform.position.x)
                {
                    playerSide = "right";
                }
                else
                {
                    playerSide = "left";
                }
            }

            movementTimer += Time.deltaTime/2;

            

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("colision");

        if (collision.transform.tag == "Player")
        {

            print("player Colision");
            
            Instantiate(heart, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
