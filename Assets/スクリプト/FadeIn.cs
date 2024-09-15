using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] public float FadeTime = 1f;
    public void SceneFadeIn()
    {
        GetComponent<Image>().DOFade(1, FadeTime);
    }
}
