using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public GameObject Again, Quit;

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
