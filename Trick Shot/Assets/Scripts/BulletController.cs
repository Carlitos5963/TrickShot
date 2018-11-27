using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed = 200f;  //Speed of bullet
    public GameObject player;   //Center of snipers body
    public GameObject barrel;   //Tip of gun barrel
    private Vector2 playerVec;
    private Vector2 barrelVec;
    private Vector2 C;          //Vector used to calculate angle between vectors above
    private float bulletAngle;

    private Rigidbody2D rb;


    private float x, y, z;

	// As soon as bullet is created, this will give the velocity
	void Start () {
        playerVec = player.transform.position;
        barrelVec = barrel.transform.position;
        C = barrelVec - playerVec;
        bulletAngle = Mathf.Atan2(C.y, C.x);
        //Giving the velocity proportional to the degree the gun is pointing
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Mathf.Cos(bulletAngle), Mathf.Sin(bulletAngle)) * speed;

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("bulletAngle = " + bulletAngle* Mathf.Rad2Deg);
    }
}
