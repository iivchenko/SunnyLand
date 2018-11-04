using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("Level 2");
    }
}
