using UnityEngine;
using UnityEngine.UI;

public class displayHeart : MonoBehaviour {

    PlayerCollision pc;
    public Text displayheart;
   

    void Update () {
        GameObject x = GameObject.Find("Player");
        PlayerCollision playerCollision = x.GetComponent<PlayerCollision>();
        //Debug.Log(playerCollision.health);

        if(playerCollision.health == -1)
        {
            displayheart.text = "Died!";
        }
        else
        {
            displayheart.text = "Life: " + playerCollision.health;
        }
         

    }
}
