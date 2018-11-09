using System.Linq;
using UnityEngine.SceneManagement;

public sealed class ExitDoorReachedEventHandler : TriggerHandler
{
    public string[] _actors;

    private LevelSystem _system;

    public void Awake()
    {
        _system = GetComponent<LevelSystem>() as LevelSystem;
    }

    public override void Handle(TriggerEventArgs args)
    {
        if (_actors.Contains(args.Other.tag))
        {
            SceneManager.LoadScene(_system._nextScene);
        }
    }
}
