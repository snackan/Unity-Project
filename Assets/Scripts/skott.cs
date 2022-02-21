//Sn�ckan
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
        //Eftersom att den pekar �t ett h�ll , d�r upp�t �r toppen av skottet kan vi g�ra s� h�r och s� kommer det funka f�r alla skottrotationer.
        rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Om skottet nuddar n�gonting g�r det s�nder.
        Destroy(skott_);
    }
}
