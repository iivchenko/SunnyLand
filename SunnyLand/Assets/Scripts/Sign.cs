using System.Linq;
using UnityEngine;

public sealed class Sign : MonoBehaviour
{
    private MeshRenderer _text;

    public void Awake()
    {
        _text = GetComponentsInChildren<MeshRenderer>().First();
    }

    public void Start()
    {
        _text.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _text.enabled = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            _text.enabled = false;
        }
    }
}
