using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // References to the RigidBody component
    public Rigidbody rb;

    public float forwardForce = 5000f;
    public float sidewaysForce = 100f;
	
	// FixedUpdate is called once per frame to make use of physics
	void FixedUpdate () {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Questions");
        }
    }
}
