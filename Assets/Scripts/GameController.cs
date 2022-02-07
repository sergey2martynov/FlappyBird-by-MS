using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; set; } = false;

    public bool CheckTheEndOfTheGame ()
    {
        if (IsGameOver)
        {
            return true;
        }
        return false;
    }
}