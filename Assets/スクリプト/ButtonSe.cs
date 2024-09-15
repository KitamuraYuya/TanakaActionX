using UnityEngine;

public class ButtonSe : MonoBehaviour
{
    public void AudioPlay()
    {
        GetComponent<AudioSource>().Play();
    }
}