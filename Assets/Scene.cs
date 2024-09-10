using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
   public void Laod(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
