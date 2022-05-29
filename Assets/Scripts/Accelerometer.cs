using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    //https://www.youtube.com/watch?v=fsEkZLBeTJ8 is the video I've used, to create this script. The accelaremeter script is used to make the accelarator work.
    //As his was a 3D game with a cube, I made a Rigid body. This isn't that important for my script. The important part for me, is knowing the data of the location of my phone, due to
    //the accelarameter.
    
    private Rigidbody rigid;
    public bool isFlat = true;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rigid.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
    }
}
