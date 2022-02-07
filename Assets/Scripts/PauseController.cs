using System;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;

    public bool IsPause { get; set; } = false;

    public event Action GameIsPaused;

    public event Action GameIsUnpaused;

    private void Start()
    {
        _inputManager.EscapePressed += TakeAPause;
    }

    private void TakeAPause()
    {
        IsPause = !IsPause;
        if (IsPause)
        {
            GameIsPaused?.Invoke();
        }

        if (!IsPause)
        {
            GameIsUnpaused?.Invoke();
        }
    }

    public bool СheckIfTheGameIsPaused()
    {
        return IsPause;
    }
}