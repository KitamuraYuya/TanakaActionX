using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Start()
    {
        this.transform.DOMove(new Vector3(50f, 0.5f, 0f), 5f);
    }
}
