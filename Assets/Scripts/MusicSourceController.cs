//Snäckan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSourceController : MonoBehaviour
{
    [SerializeField]
    AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //Denna kod loopar musiken.
        if (AS.isPlaying == false)
        {
            AS.Play();
        }
    }
}
