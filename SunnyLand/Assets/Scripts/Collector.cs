using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class ItemCollectedEvent : UnityEvent<int> { }

public class Collector : MonoBehaviour
{
    public ItemCollectedEvent OnCollected;
    private List<GameObject> _colliders;

    public int Scores { get; private set; }

   

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

        var item = other.GetComponent<Collectable>() as Collectable;

        if (item != null)
        {
            Scores += item._scores;
            if (OnCollected != null)
            {
                OnCollected.Invoke(Scores);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        _colliders.Remove(other.gameObject);
    }
}
