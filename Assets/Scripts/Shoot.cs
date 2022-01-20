using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    KeyCode shoots;
    [SerializeField]
    GameObject skottes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoots))
        {
            Instantiate(skottes, transform.position + transform.up, transform.rotation);
            print("Hej mamma");
        }
        if (Input.GetKey(shoots))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej mamma");
        }
    }
}
