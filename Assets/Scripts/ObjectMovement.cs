using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;

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
}