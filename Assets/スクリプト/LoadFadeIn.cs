using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LoadFadeIn : MonoBehaviour
{
    [SerializeField] float FadeTime = 1f;
    public void Start()
    {
        GetComponent<Image>().DOFade(1, FadeTime);
    }
}
