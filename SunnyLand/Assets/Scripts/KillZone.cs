using System;
using UnityEngine;
using UnityEngine.Events;

public class KillZoneReachedEventArgs
{
    public KillZoneReachedEventArgs(GameObject reacher)
    {
        Reacher = reacher;
    }

    public GameObject Reacher { get; private set; }
}

[Serializable]
public class KillZoneReached : UnityEvent<KillZoneReachedEventArgs>
{
}

public class KillZone : MonoBehaviour
{
    public KillZoneReached KillZoneReached;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (KillZoneReached != null)
        {
            KillZoneReached.Invoke(new KillZoneReachedEventArgs(other.gameObject));
        }
    }
}