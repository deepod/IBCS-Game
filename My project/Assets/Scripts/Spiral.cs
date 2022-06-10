using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{

public float spiralRotateSpeed = 1; // determines the speed the spiral rotates.

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,0,spiralRotateSpeed,Space.World);
    }
}
