using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");
        //Debug.Log("Ž€–S");
    }
}
