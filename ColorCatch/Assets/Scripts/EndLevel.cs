using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour {

    public void levelEndAutoNext()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
