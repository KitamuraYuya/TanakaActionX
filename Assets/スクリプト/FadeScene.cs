using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScene : MonoBehaviour
{
   public void Fade(string SceneName)
    {
        FadeManager.Instance.LoadScene(SceneName, 1.0f);
    }
}
