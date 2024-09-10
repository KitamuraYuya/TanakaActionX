using UnityEngine;

public class Coin : ItemBase
{

    [SerializeField] int _score = 10;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(_score);
    }
}
