using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(1 * movementSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-1 * movementSpeed, 0);
        }
    }
}
