using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxEnemyBehaviour : MonoBehaviour
{
    //variables used
    public float movementSpeed;
    public string playerSide;

    //get the player object to find its position later
    Playermovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playermovement>();

    }

    // Update is called once per frame
    void Update()
    {

        //always moves based on its movement speed
        transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;

        //if the player is on the enemies right side, increase movementspeed and when movementspeed is more than 0 the enemy moves to the right
        if (playerSide == "right" && movementSpeed < 8)
        {
            movementSpeed += 0.1f;
        }
        //if the player is on the enemies left side, decrease movementspeed and when movementspeed is less than 0 the enemy moves to the left
        else if (playerSide == "left" && movementSpeed > -8)
        {
            movementSpeed -= 0.1f;
        }
        //this makes it so the enemy has to accelerate and if the player jumps over it it will have to slow down before turning around


        //checks which side the player is on in relation to the enemies position
        if (player.transform.position.x > transform.position.x)
        {
            playerSide = "right";
        }
        else
        {
            playerSide = "left";
        }
    }
}
