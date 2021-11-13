using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float delay = 7;
    public string NewLevel = "Demoscene";


    void Start()
    {
        // PLAY BackgroundMusic and Countdown audio file
        // FindObjectOfType<AudioManager>().Play("BackgroundMusic");
        {
            StartCoroutine(LoadLevelAfterDelay(delay));
        }

        IEnumerator LoadLevelAfterDelay(float delay)
        {
            yield return new WaitForSecondsRealtime(delay);
            SceneManager.LoadScene(NewLevel);
        }
    }
}