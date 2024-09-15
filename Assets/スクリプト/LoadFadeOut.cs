using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class LoadFadeOut : MonoBehaviour
{
    [SerializeField] float FadeTime = 1f;
    public void Start()
    {
        GetComponent<Image>().DOFade(0, FadeTime);
    }

}
