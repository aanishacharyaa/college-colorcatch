using System.Timers;
using UnityEngine;

public class PlayerColor : MonoBehaviour {


    Color[] colors = { Color.green, Color.red, Color.gray, Color.blue, Color.yellow, Color.black, Color.cyan, Color.magenta };
    public GameObject Player;
    public float playerColorChange = 1.0f;

    void Start() {
        InvokeRepeating("RepetePlayer", 0.1f, playerColorChange);
    }


    void Update() {

       

    }

    void RepetePlayer()
    {
       
        Player.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
}
