using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //private Rigidbody2D rb2d;
    public GameObject bullet;
    public GameObject barrel;
    Vector2 barrelPosition;

    public float smooth = 4.0f;
    public float tiltAngle = 85.0f;

    //User can control rotation of player
    void Update()
    {
        // Tilts player with arrow keys as determined in Input settings
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
 
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, target, Time.deltaTime);

        //Use Either mouse click or ctrl to fire
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //Will instatiate bullet object when called at the tip of gun barrel
    //Will also destroy bullets after 5 seconds
    public void Shoot()
    {
        barrelPosition = barrel.transform.position;
        var copy = Instantiate(bullet, barrelPosition, Quaternion.identity);
        Destroy(copy, 5f);
    }
}