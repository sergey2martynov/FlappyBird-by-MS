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
        if (_gameController.CheckTheEndOfTheGame() || _pauseController.СheckIfTheGameIsPaused())
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.ChangeTheSpeed(_columnMotionVector);
        }
    }

    public void Inject(GameController gameController, PauseController pauseController)
    {
        _gameController = gameController;
        _pauseController = pauseController;
    }
}