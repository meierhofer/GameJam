using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] listOfNoises;
    public float delay = 5f;


    

    void Start()
    {

        StartCoroutine(NoiseRoutine());

    }
    IEnumerator NoiseRoutine()
    {



        yield return new WaitForSeconds(delay);
        transform.GetComponent<AudioSource>().clip = listOfNoises[Random.Range(0, listOfNoises.Length)];
        transform.GetComponent<AudioSource>().Play();
        StartCoroutine(NoiseRoutine());

    }
}
