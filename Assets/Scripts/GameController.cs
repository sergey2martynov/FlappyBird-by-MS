using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; set; } = false;

    public bool CheckTheEndOfTheGame ()
    {
        return IsGameOver;
    }
}