using System;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;

    public bool IsPause { get; set; }

    public event Action PauseIsTrue;

    public event Action PauseIsFalse;

    private void Start()
    {
        _inputManager.EscapePressed += TakeAPause;
    }

    public void TakeAPause()
    {
        IsPause = !IsPause;
        if (IsPause)
        {
            PauseIsTrue?.Invoke();
        }

        if (IsPause == false)
        {
            PauseIsFalse?.Invoke();
        }
    }
}