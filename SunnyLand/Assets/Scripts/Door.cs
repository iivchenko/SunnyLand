using System;
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
    public DoorReached DoorReached;

    public void OnTriggerEnter2D(Collider2D other)
    {
       if(DoorReached != null)
        {
            DoorReached.Invoke(new DoorReachedEventArgs(this.gameObject, other.gameObject));
        }
    }
}
