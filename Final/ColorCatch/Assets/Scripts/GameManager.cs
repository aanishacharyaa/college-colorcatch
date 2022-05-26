using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool GameEnd = false;
    public float RestartDelay = 1f;
    public GameObject completeUI;
    public GameObject pushGameImg;
    public GameObject controlImg;
    
   
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




    public void Start()
    {
        pushGameImg.SetActive(false);
        controlImg.SetActive(false);
    }

    public void Update()
    {
        Gamepush();
    }

    public void onclickcontrol()
    {
        controlImg.SetActive(true);
    }
    public void onclickback()
    {
        controlImg.SetActive(false);
    }

    public void Gamepush()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pushGameImg.SetActive(true);


        }
    }

    public void resume()
    {
        pushGameImg.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }

  




}
