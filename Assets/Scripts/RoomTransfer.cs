//Snäckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{
    [SerializeField]
    Camera camera_;
    [SerializeField]
    GameObject player;
    [SerializeField]
    Vector3 newCampos;
    [SerializeField]
    Vector3 newPlayerPos;
    [SerializeField]
    string applyTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (applyTo == "nil")
        {
            camera_.transform.position = newCampos;
            player.transform.position = newPlayerPos;
        }
        else
        {
            if (collision.gameObject.tag == applyTo)
            {
                camera_.transform.position = newCampos;
                player.transform.position = newPlayerPos;
            }
            else
            {
                print("Object does not belong to group");
            }
        }
    }
}


