using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LaodFadeText : MonoBehaviour
{
    [SerializeField] public float FadeTime = 1f;
    public void Start()
    {
        GetComponent<Text>().DOFade(1, FadeTime);
    }
}
