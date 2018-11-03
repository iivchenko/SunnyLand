using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CollectGem : MonoBehaviour
{
    public GameObject _player;
    public GameObject _gem;

    private Collider2D _playerCollider;
    private Collider2D _objectCollider;
    
	void Start ()
    {
        _playerCollider = _player.GetComponent<Collider2D>();
        _objectCollider = _gem.GetComponent<Collider2D>();
    }

	void Update ()
    {
		if (_objectCollider.bounds.Intersects(_playerCollider.bounds))
        {
            Destroy(_gem);
        }
	}
}
