using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] int _time = 5;
    private void Sceneblackout()
    {
        GetComponent<Image>().DOFade(0, 5);
        SceneManager.LoadScene("GScene");
    }
}
