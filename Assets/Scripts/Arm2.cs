using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm2 : MonoBehaviour// koden är gjord av Mickael
{

    /*public event EventHandler<OnShootEventargs> OnShoot;
    public class OnShootEventargs : EventArgs
    {
        public Vector3 gunEndPointPosition;
        public Vector3 shootPosition;
    }
    private Transform aimGunEndPointTransform;*/



    // Start is called before the first frame update
    private void Awake()
    {
        /*aimGunEndPointTransform = aimGunEndPointTransform.Find("GunEndPointPosition");*/
    }
    private void Update()
    {
        /*HandlesShooting();*/
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    } // den här koden riktar valfritt objekt mot vart musen pekar.

    private void HandleAiming()
    {
        /*Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();*/

    }

}
    /*private void HandlesShooting()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
            OnShoot?.Invoke(this, new OnShootEventargs
            {
                gunEndPointPosition = aimGunEndPointTransform.position,
                shootPosition = mousePosition,
            }) ;*/
       /* }
    }*/

