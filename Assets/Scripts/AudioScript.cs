using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
    }

    private void Update()
    {
       
    }

    public void playSound() 
    {
        audioSource.Play();

    }
}
