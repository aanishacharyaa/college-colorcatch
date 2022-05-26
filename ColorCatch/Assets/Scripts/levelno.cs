using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelno : MonoBehaviour {

    public Text level;

    void Update()
    {

        level.text = "LEVEL : " + SceneManager.GetActiveScene().buildIndex.ToString();

    }

    //level.text = SceneManager.GetActiveScene().buildIndex.ToString();



}
