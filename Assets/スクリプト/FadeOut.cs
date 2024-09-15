using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeOut : MonoBehaviour
{
    [SerializeField] public float FadeTime = 1f;
    public void SceneFadeOut()
    {
        GetComponent<Image>().DOFade(0, FadeTime);
    }
}
