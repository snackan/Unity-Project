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
    [SerializeField]
    int offsetY;
    [SerializeField]
    Vector3 cameraTargetPos;
    [SerializeField]
    Camera cam;
    setCameraTargetPos setcameratargetpos;
    // Start is called before the first frame update
    void Start()
    {
        setcameratargetpos = FindObjectOfType<setCameraTargetPos>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
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
            player.transform.position = checkpointPos + new Vector3(0, offsetY, 0);
            cam.transform.position = cameraTargetPos;



        }
        if (collision.gameObject.tag == "CameraTargetSet")
        {
            cam.transform.position = setcameratargetpos.campostarget;
        }
    }
}
