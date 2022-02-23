//Snäckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    [SerializeField]
    string customTag;
    [SerializeField]
    int buildIndexScene;
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
        if (customTag == "nil")
        {
            //Den här metoden använder man om alla GameObjects ska kunna aktivera scene teleporten.
            print("No custom tag requirement applied");
            SceneManager.LoadScene(buildIndexScene);
        }
        else
        {
            //Den här metoden används om man bara vill att en typ av GameObject ska kunna aktivera scene teleporten.
            if (collision.gameObject.tag == customTag)
            {
                //Om kollisionens gameobject har rätt tagg kommer teleporten aktiveras.
                SceneManager.LoadScene(buildIndexScene);
            }
            else
            {
                //Annars kommer inget hända.
                print("Object does not have the correct tag");
            }
        }
    }
}
