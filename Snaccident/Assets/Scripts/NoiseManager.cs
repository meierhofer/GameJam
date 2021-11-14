using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseManager : MonoBehaviour
{
    public AudioClip[] listOfNoises;
    public float delay = 5f;


    //public List<AudioClip> listOfNoises = new List< AudioClip >();

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
    // Update is called once per frame
    void Update()
    {
        
    }
}
