using UnityEngine;
using UnityEngine.SceneManagement;

public class OverScene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
