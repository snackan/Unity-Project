using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float startY; 
    public bool startMovement = true;
    public float attackTimer;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;

    }

// Update is called once per frame
void Update()
    {
        if (startMovement == true)
        {
            transform.position = new Vector3(0, 0.5f, 0) * Time.deltaTime;

            if (transform.position.y > startY + 3)
            {
                startMovement = false;
            }
        }
    }
}
