using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    private GameController _gameController;

    private PauseController _pauseController;

    private const float Speed = -1.5f;

    private void Start()
    {
        _rigidbody.velocity = new Vector2(Speed, 0);
    }

    private void Update()
    {
        if (_gameController.IsGameOver || _pauseController.IsPause)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.velocity = new Vector2(Speed, 0);
        }
    }

    public void SendAGameControllerReference(GameController gameController)
    {
        _gameController = gameController;
    }

    public void SendAPauseControllerReference(PauseController pauseController)
    {
        _pauseController = pauseController;
    }
}