using UnityEngine;

public class BirdJumper : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField] private Animator _animator;

    private const float UpForce = 150.0f;

    public void Jump()
    {
        if (_gameController.IsGameOver == false && _pauseController.IsPause == false)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(new Vector2(0, UpForce));
            _animator.SetTrigger("Flap");
        }
    }
}