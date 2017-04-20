using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {
    //public Transform player;
    public Rigidbody playerBody;
    Vector3 deltaPos;
    public float speedMultiplier;
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        deltaPos.z = Input.GetAxis("Vertical");
        deltaPos.x = Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Vertical"));
        // Debug.Log(Input.GetAxis("Horizon"));
        //player.position = player.position + deltaPos;
        //transform.position += deltaPos aris igive rac zeda; 
    }

    private void FixedUpdate()
    {
        //playerBody.position = playerBody.position + deltaPos;
        playerBody.AddForce(deltaPos * speedMultiplier);
    }
}
