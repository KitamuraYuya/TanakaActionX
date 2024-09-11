using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class Laod : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().DOFade(0, 5);
    }

}
