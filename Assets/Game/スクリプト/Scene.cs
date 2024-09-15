using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Laod(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}

