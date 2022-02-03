using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event Action SpacePressed;

    public event Action EscapePressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpacePressed?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapePressed?.Invoke();
        }
    }
}