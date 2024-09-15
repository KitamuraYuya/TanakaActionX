using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
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
            Debug.Log("���y���~�߂�");
        }

        //if (_budeio.isPlaying)
        //{
        //    SceneManager.LoadScene("GameOverScene");
        //    Debug.Log("�V�[���� �ς��� ");
        //}
    }
}
