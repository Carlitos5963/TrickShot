using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed = 50f;
    public float velocityX;
    public float velocityY;
    public GameObject player;
    public GameObject barrel;
    private Vector2 playerVec;
    private Vector2 barrelVec;
    private Vector2 newForce;
    private float bulletAngle;

    private Rigidbody2D rb;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        playerVec = player.transform.position;
        barrelVec = barrel.transform.position;
        bulletAngle = Vector2.Angle(playerVec, barrelVec);
        //rb.velocity = new Vector2(Mathf.Cos(bulletAngle), Mathf.Sin(bulletAngle)) * speed;


    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("bulletAngle = " + bulletAngle);
        rb.position += new Vector2(Mathf.Cos(bulletAngle), Mathf.Sin(bulletAngle)) * speed;
    }
}
//TO-DO
//In this script, figure out how to get velocity according to angle between vectors
