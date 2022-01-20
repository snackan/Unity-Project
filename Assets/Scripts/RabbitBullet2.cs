using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitBullet2 : MonoBehaviour
{

    Playermovement player;
    public string playerSide;
    public float lifeTimer = 0;

    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playermovement>();

        if (player.transform.position.x > transform.position.x)
        {
            playerSide = "right";
        }
        else
        {
            playerSide = "left";
        }

        direction = new Vector3(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y, 0);
        direction.Normalize();

        


    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer += Time.deltaTime;

        transform.position += direction * 5 * Time.deltaTime;

        //if (playerSide == "right")
        //{
        //    transform.position += new Vector3(7, 0, 0)*Time.deltaTime;
        //}
        //else if (playerSide == "left")
        //{
        //    transform.position -= new Vector3(7, 0, 0)*Time.deltaTime;
        //}

        if (lifeTimer > 5)
        {
            Destroy(gameObject);
        }

    }
}
