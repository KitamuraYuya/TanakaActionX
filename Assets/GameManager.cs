using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _scoreText = default;

    int _score = 0;
    void Start()
    {
        AddScore(0);
    }
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("0000");
    }
}
