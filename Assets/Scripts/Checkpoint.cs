//snäckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    Vector3 checkpointPos;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hifwfiwe");
        if (collision.gameObject.tag == "Checkpoint")
        {
            print("hifwfiwe");
            checkpointPos = collision.gameObject.transform.position;
        }
        if (collision.gameObject.tag == "Dödablocken")
        {
            print("hifwfiwe");
            player.transform.position = checkpointPos;
        }
    }
}
