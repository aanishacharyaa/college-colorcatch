using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public Transform tb;
    public float fordwardForce = 2000f;
    public float sidewayForce = 500f;
	// Use this for initialization
	void Start () {
         
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, fordwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(- sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(tb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}
