using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Audioforwin : MonoBehaviour
{
    public AudioSource audioSource; // Assign your AudioSource in the Inspector
    public float delay =5f; // Delay in seconds

    void Start()
    {
        StartCoroutine(PlayAudioWithDelay());
    }

    private IEnumerator PlayAudioWithDelay()
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        audioSource.Play(); // Play the audio
    }
}
