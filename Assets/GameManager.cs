using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _maxLife = 5;
    [SerializeField] int _startLife = 1;
    [SerializeField] Text _lifeText = default;
    [SerializeField] Text _scoreText = default;

    int _score = 0;
    int _life = 0;
    void Start()
    {
        _life = _startLife;
        AddLife(0);
        AddScore(0);
    }


    public void AddLife (int life)
    {
        _life += life;
        _lifeText.text = _life.ToString("D1");
    }
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("D1");
    }
}
