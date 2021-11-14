using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadScene(2);
    }

public void QuitGame() 
    {
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}
