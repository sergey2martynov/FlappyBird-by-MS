using System;
using UnityEngine;

public class BirdJumper : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;

    [SerializeField] private InputManager _inputManager;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField] private Animator _animator;

    [SerializeField] private float _jumpForce = 150f;
    
    private Vector2 _jumpVector;
    
    private static readonly int Flap = Animator.StringToHash("Flap");

    private void Start()
    {
        _jumpVector = new Vector2(0, _jumpForce);
        
        _inputManager.SpacePressed += Jump;
    }

    private void Jump()
    {
        if (!_gameController.IsGameOver && !_pauseController.IsPause)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(_jumpVector);
            _animator.SetTrigger(Flap);
        }
    }

    private void OnDestroy()
    {
        _inputManager.SpacePressed -= Jump;
    }
}