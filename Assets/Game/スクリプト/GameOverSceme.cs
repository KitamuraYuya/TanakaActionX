using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSceme : MonoBehaviour
{
    [SerializeField] AudioSource _audio;
    [SerializeField] Collider2D _collider;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_audio.isPlaying)
        {
            _audio.Stop();
        }
        Debug.Log("‰¹Ž~‚ß");
    }
}
