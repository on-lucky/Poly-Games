using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

    public float speed;
    public float jumpspeed;
    Rigidbody2D physics;

    // Use this for initialization
    void Start () {
        physics = GetComponent<Rigidbody2D>();
        physics.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("space") || Input.GetKeyDown("up"))
        {
            physics.velocity = new Vector2(physics.velocity.x, jumpspeed);
        }
        if (Input.GetKey("left"))
        {
            physics.velocity = new Vector2(-speed, physics.velocity.y);
        }
        else if (Input.GetKey("right"))
        {
            physics.velocity = new Vector2(speed, physics.velocity.y);
        }
    }
}
