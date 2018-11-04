using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class ItemCollectedEvent : UnityEvent<int> { }

public class Collector : MonoBehaviour
{
    public ItemCollectedEvent OnCollected;

    public int Scores { get; private set; }

    public void OnTriggerEnter2D(Collider2D other)
    {
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
}
