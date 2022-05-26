using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameObject player;
    public int health = 0; 

     void OnCollisionEnter (Collision collisionInfo)
    {
       //Debug.Log("target color "+collisionInfo.collider.GetComponent<MeshRenderer>().material.color.ToString());

        //Debug.Log("player color" + player.GetComponent<MeshRenderer>().material.color.ToString());

        if( collisionInfo.collider.GetComponent<MeshRenderer>().material.color == player.GetComponent<MeshRenderer>().material.color)
        {
            // Debug.Log("same color!");
            //GetComponent<Collider>().enabled = false;
            collisionInfo.collider.GetComponent<BoxCollider>().enabled = false;
            collisionInfo.collider.GetComponent<Rigidbody>().mass = 0;
            collisionInfo.collider.GetComponent<Rigidbody>().useGravity = false;
            collisionInfo.collider.GetComponent<MeshRenderer>().enabled = false;
            health++;
            


        }
        else
        {
            

            //Debug.Log("different color");
            if (collisionInfo.collider.tag == "Obstacle")
            {

                if (health == 0)
                {
                    movement.enabled = false;
                    //movement.fordwardForce = 0f;
                    FindObjectOfType<GameManager>().EndGame();
                }

                collisionInfo.collider.GetComponent<BoxCollider>().enabled = false;
                collisionInfo.collider.GetComponent<Rigidbody>().mass = 0;
                collisionInfo.collider.GetComponent<Rigidbody>().useGravity = false;
                collisionInfo.collider.GetComponent<MeshRenderer>().enabled = false;
                health--;





            }
        }

      
    }

}
