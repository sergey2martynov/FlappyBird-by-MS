using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; set; }

    private void Start()
    {
        IsGameOver = false;
    }
}