using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] AudioSource _sound = default;
    [SerializeField] ActivateTiming _whemActivated = ActivateTiming.Get;

    public abstract void Activate();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if(_sound)
            { 

            }

            if (_whemActivated == ActivateTiming.Get)
            {
                Activate();
                Destroy(this.gameObject);
            }
            else if (_whemActivated == ActivateTiming.Use)
            {
                this.transform.position = Camera.main.transform.position;
                GetComponent<Collider2D>().enabled = false;
                collision.gameObject.GetComponent<PlayerController>().GetItem(this);
            }
        }
    }

    enum ActivateTiming
    {
        Get,

        Use,
    }
}
