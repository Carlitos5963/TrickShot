using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public GameObject bullet;
    public GameObject barrel;
    Vector2 barrelPosition;

    public float smooth = 4.0f;
    public float tiltAngle = 80.0f;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
 
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, target, Time.deltaTime * smooth);
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    public void shoot()
    {
        barrelPosition = barrel.transform.position;
        var copy = Instantiate(bullet, barrelPosition, Quaternion.identity);
        Destroy(copy, 3.0f);

    }
}

//TO-DO
//In this script, figure out how to instantiate bullet at barrels position