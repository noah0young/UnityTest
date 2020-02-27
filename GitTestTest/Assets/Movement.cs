using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody myRigidbody;
	public float jump;
	private bool canJump2;
	private bool canJump3;
	private bool canJump4;
	// Start is called before the first frame update
	void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector3(speed * Input.GetAxis("Horizontal"), myRigidbody.velocity.y, speed * Input.GetAxis("Vertical"));
		if (canJump4)
		{
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump4 = false;
			}
		}
		if (canJump3)
		{
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump3 = false;
				canJump4 = true;
			}
		}
		if (canJump2)
		{
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump2 = false;
				canJump3 = true;
			}
		}
		if (myRigidbody.velocity.y == 0f)
		{
			canJump2 = false;
			canJump3 = false;
			canJump4 = false;
			if (Input.GetKeyDown("space"))
			{
				myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jump, myRigidbody.velocity.z);
				canJump2 = true;
			}
        }
    }
}
