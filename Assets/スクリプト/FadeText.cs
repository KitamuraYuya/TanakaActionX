using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
    [SerializeField] public float FadeTime = 1f;
    public void Fade()
    {
        GetComponent<Text>().DOFade(1, FadeTime);
    }
}
