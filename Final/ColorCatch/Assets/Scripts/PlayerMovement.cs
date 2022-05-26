using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class PlayerMovement : MonoBehaviour {


   public Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    public Text left, right, jump;
    private GameObject currentkey;

    


    public Rigidbody rb;
    public Transform tb;
    public float fordwardForce = 2000f;
    public float sidewayForce = 500f;

   


    // Use this for initialization
    void Start () {
        keys.Add("Left", KeyCode.A);
        keys.Add("Right", KeyCode.D);
        //keys.Add("Jump", KeyCode.S);

        
        left.text = keys["Left"].ToString();
        right.text = keys["Right"].ToString();
        //jump.text = keys["Jump"].ToString(); 
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, fordwardForce * Time.deltaTime);

        if (Input.GetKey(keys["Right"]))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(keys["Left"]))
        {
            rb.AddForce(- sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(tb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}



    void OnGUI()
    {
        if (currentkey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                keys[currentkey.name] = e.keyCode;
                currentkey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                currentkey = null;
            }
        }
    }

    public void ChangeKey(GameObject clicked)
    {
        currentkey = clicked;
    }




}
