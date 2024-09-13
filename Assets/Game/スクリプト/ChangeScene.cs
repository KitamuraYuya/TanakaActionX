using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]  GameObject audioObject;
    [SerializeField] private Image _PanelImage;
    [SerializeField] private float _speed;

    private bool isSceneChange;
    private Color PanelColor;

    public void AudioPlay()
    {
        audioObject.GetComponent<AudioSource>().Play();
    }

    private void Awake()
    {
        isSceneChange = false;
        PanelColor = _PanelImage.color;
    }

    public void blackout()
    {
        StartCoroutine(Sceneblackout());
    }

    private IEnumerator Sceneblackout()
    {
        while (!isSceneChange)
        {
            PanelColor.a += 0.1f;
            _PanelImage.color = PanelColor;

            if (PanelColor.a >= 1)
                isSceneChange = true;

            yield return new WaitForSeconds(_speed);
        }
        SceneManager.LoadScene("GScene");
    }
}