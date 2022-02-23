//Snäckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skott : MonoBehaviour
{
    [SerializeField]
    float speed;

    Rigidbody2D rb;
    [SerializeField]
    GameObject skott_;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Eftersom att den pekar åt ett håll , där uppåt är toppen av skottet kan vi göra så här och så kommer det funka för alla skottrotationer.
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Om skottet nuddar någonting går det sönder.
        Destroy(skott_);
    }
}
