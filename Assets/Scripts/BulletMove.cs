//Sn�ckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField]
    public float speed = 20f;
    public Rigidbody2D rb;
    [SerializeField]
    GameObject skott;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forts�tt flytta skottet i r�tt h�ll.
        rb.velocity = transform.right * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(skott);
    }
}
