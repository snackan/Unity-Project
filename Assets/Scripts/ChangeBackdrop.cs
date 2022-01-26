using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackdrop : MonoBehaviour
{
    [SerializeField]
    GameObject backdrop1;
    [SerializeField]
    GameObject backdrop2;
    [SerializeField]
    Vector3 brazil;
    [SerializeField]
    GameObject player;


    //When the backdrop is not in use, send it to brazil

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
        backdrop1.transform.position = brazil;

        backdrop2.transform.position = player.transform.position;
    }
}
