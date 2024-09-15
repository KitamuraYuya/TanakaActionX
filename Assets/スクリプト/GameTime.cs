using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameTime : MonoBehaviour
{
    Text time;
    private void Start()
    {
        time = GetComponent<Text>();
        time.text = 60.ToString("00");
        time.DOCounter(60, 0, 3f)
        .SetEase(Ease.Linear)
        .SetDelay(0.5f);
    }
}
