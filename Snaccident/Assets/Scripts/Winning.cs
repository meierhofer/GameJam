using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    public GameObject TryNew, Quitscreen;

    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() 
    {
        Application.Quit();
        //UnityEditor.EditorApplication.ExitPlaymode(); //exits the playmode in the Editor
        Application.Quit();  //exit for the build game
    }
}
