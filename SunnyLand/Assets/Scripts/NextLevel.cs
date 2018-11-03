using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string _nextScene;
    public GameObject _player;
    public GameObject _exitPoint;

    private Collider2D _collider1;
    private Collider2D _collider2;

    public void Awake()
    {
        _collider1 = _exitPoint.GetComponent<Collider2D>();
        _collider2 = _player.GetComponent<Collider2D>();
    }
    
	void Update ()
    {
        if (_collider1.bounds.Intersects(_collider2.bounds))
        {
            SceneManager.LoadScene(_nextScene);
        }
	}
}
