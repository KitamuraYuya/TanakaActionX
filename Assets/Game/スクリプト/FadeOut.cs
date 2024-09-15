using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().DOFade(0, 5);
    }

}
