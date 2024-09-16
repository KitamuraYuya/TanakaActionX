using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{

    [SerializeField] Vector3 targetPosition = new Vector3(1.5f, 0, 0);
    [SerializeField] float duration = 1;
    [SerializeField] Ease ease = Ease.Linear;
    SpriteRenderer _sprite = default;

    void Start()
    {
        transform.DOMove(targetPosition, duration).SetLoops(-1, LoopType.Yoyo).SetEase(ease);
        _sprite = GetComponent<SpriteRenderer>();
    }
}