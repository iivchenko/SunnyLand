using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string _collectableBy;
    public int _scores;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (string.Equals(_collectableBy, other.tag, System.StringComparison.OrdinalIgnoreCase))
        {
            Destroy(gameObject);
        }
    }
}