using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("CScene");
        //Debug.Log("ÉNÉäÉA");
    }
}