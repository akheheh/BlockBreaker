using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {
        //variable for our current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Load next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //We need to use this to get back to start scene (bro, no array is infinite)
    public void LoadStartScene() {
        SceneManager.LoadScene(0);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
