//Snäckan
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
        //Vid en kollision kommer bakgrunderna att bytas. Backdrop1 är den som man redan har, och backdrop2 är den som kommer komma upp när man går in i en kollision
        //"brazil" är bara stället som bakgrunden som byts ut går till.
        backdrop1.transform.position = brazil;

        //Den nya backdropen kommer till spelaren och eftersom att den är parentad till spelaren följer den efter.
        backdrop2.transform.position = player.transform.position;
    }
}
