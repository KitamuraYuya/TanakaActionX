using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melody : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip sound;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    public void Playsound()
    {
        audioSource.PlayOneShot(sound);
    }
}