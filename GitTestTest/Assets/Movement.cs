﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody myRigidbody;
	public float jump;
	private bool canJump2;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector3(speed * Input.GetAxis("Horizontal"), myRigidbody.velocity.y, speed * Input.GetAxis("Vertical"));
		if (canJump2)
		{
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump2 = false;
			}
		}
		if (myRigidbody.velocity.y == 0f)
		{
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump2 = true;
			}
        }
    }
}