using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 20;
    private Rigidbody playerRig;
    private Vector3 movement;

	void Awake () {
        playerRig = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
    }

	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);

		movement = movement.normalized * speed * Time.deltaTime;

		playerRig.MovePosition (transform.position + movement);
	}	
}
