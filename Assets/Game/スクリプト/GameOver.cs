using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] float countup = 0.5f;
    [SerializeField] AudioSource _audeio;
    [SerializeField] AudioSource _budeio;

    private void Start()
       => _audeio = GetComponent<AudioSource>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _audeio.Play();

        if (_budeio.isPlaying)
        {
            _budeio.Stop();
            countup += Time.deltaTime;
            Debug.Log("‰¹Šy‚ðŽ~‚ß‚é");
        }

        if (countup <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
            Debug.Log("ƒV[ƒ“‚ð •Ï‚¦‚é ");
        }
    }
}
