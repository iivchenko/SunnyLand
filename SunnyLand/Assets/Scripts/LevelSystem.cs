using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSystem : MonoBehaviour
{
    public string _nextScene;

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitDoorReachedEventHandler(DoorReachedEventArgs args)
    {
        if (args.Reacher.tag == "Player")
        {
            SceneManager.LoadScene(_nextScene);
        }
    }

    public void KillzoneReachedEventHandler(KillZoneReachedEventArgs args)
    {
        if (args.Reacher.tag == "Player")
        {
            Reset();
        }
        else
        {
            Destroy(args.Reacher);
        }
    }
}
