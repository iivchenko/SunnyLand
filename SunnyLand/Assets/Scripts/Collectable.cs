using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string _collectableBy;
    public int _scores;

    private List<GameObject> _colliders;

    public void Awake()
    {
        _colliders = new List<GameObject>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (_colliders.Contains(other.gameObject))
        {
            _colliders.Add(other.gameObject);
            return;
        }

        _colliders.Add(other.gameObject);

        if (string.Equals(_collectableBy, other.tag, System.StringComparison.OrdinalIgnoreCase))
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        _colliders.Remove(other.gameObject);
    }
}