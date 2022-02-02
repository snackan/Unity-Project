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
            print("No custom tag requirement applied");
            SceneManager.LoadScene(buildIndexScene);
        }
        else
        {
            if (collision.gameObject.tag == customTag)
            {
                SceneManager.LoadScene(buildIndexScene);
            }
            else
            {
                print("Object does not have the correct tag");
            }
        }
    }
}
