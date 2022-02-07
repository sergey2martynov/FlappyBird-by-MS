using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;
    
    [SerializeField] private float _backgroundVanishingPoint = -8.74f;

    [SerializeField] private float _backgroundAppearancePoint = 8.51f;

    private const float Speed = -1.5f;
    
    private Vector2 _objectMotionVector;

    private void Start()
    {
        _objectMotionVector = new Vector2(Speed, 0);
    }

    private void Update()
    {
        if (_gameController.CheckTheEndOfTheGame() || _pauseController.СheckIfTheGameIsPaused())
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.ChangeTheSpeed(_objectMotionVector);
        }
        
        if (transform.position.x < _backgroundVanishingPoint)
        {
            RepositionBackground();
        }
    }
    
    private void RepositionBackground()
    {
        transform.position = new Vector2(_backgroundAppearancePoint, 0);
    }

}