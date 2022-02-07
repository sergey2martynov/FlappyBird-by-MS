using System;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    private GameController _gameController;

    private PauseController _pauseController;

    private const float Speed = -1.5f;

    private Vector2 _columnMotionVector;

    private void Start()
    {
        _columnMotionVector = new Vector2(Speed, 0);
    }

    private void Update()
    {
        MoveTheObject(_gameController, _pauseController, _rigidbody,
            _columnMotionVector);
        
        
    }

    public void Inject(GameController gameController, PauseController pauseController)
    {
        _gameController = gameController;
        _pauseController = pauseController;
    }
    
    public void MoveTheObject(GameController gameController, PauseController pauseController, Rigidbody2D rb2D, Vector2 vector2)
    {
        if (gameController.CheckTheEndOfTheGame() || pauseController.СheckIfTheGameIsPaused())
        {
            rb2D.velocity = Vector2.zero;
        }
        else
        {
            rb2D.velocity = vector2;
        }
    }
    
    
}