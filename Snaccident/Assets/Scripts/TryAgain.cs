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
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}