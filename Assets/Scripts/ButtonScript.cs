using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {


    public void LoadLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
