using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class DoorReachedEventArgs
{
    public DoorReachedEventArgs(GameObject door, GameObject reacher)
    {
        Door = door;
        Reacher = reacher;
    }

    public GameObject Door { get; private set; }

    public GameObject Reacher { get; private set; }
}

[Serializable]
public class DoorReached : UnityEvent<DoorReachedEventArgs>
{
}

public class Door : MonoBehaviour
{
    public string[] _actors;
    public DoorReached DoorReached;

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

        if (_actors.Contains(other.gameObject.tag))
        {
            DoorReached.Invoke(new DoorReachedEventArgs(gameObject, other.gameObject));
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        _colliders.Remove(other.gameObject);
    }
}
