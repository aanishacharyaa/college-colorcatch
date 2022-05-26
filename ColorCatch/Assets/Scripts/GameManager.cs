using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool GameEnd = false;
    public float RestartDelay = 1f;
    public GameObject completeUI;

    public void EndGame()
    {
        if(GameEnd == false)
        GameEnd = true;
        Debug.Log("Game has ended!");
        Invoke("Restart", RestartDelay);
    }

public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

public void LevelComplete()
    {
       // Debug.Log("level complete!");
        completeUI.SetActive(true);
    }


   

}
