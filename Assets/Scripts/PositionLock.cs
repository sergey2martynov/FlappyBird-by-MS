using System;
using UnityEngine;

public class PositionLock : MonoBehaviour
{
    [SerializeField] private PauseController _pauseController;

    [SerializeField] private Rigidbody2D _birdRigidbody2D;
    
    public Vector2 ConservationOfVelocity { get; set; }

    private Vector2 ConservationOfPosition { get; set; }

    private void Start()
    {
        _pauseController.GameIsPaused += FixPosition;
    }
    
    private void Update()
    {
        if (_pauseController.IsPause)
        {
            _birdRigidbody2D.transform.position = ConservationOfPosition;
        }
    }

    private void FixPosition()
    {
        ConservationOfVelocity = _birdRigidbody2D.velocity;
        _birdRigidbody2D.velocity = Vector2.zero;
        ConservationOfPosition = _birdRigidbody2D.transform.position;
        _birdRigidbody2D.isKinematic = true;
    }

    private void OnDestroy()
    {
        _pauseController.GameIsPaused -= FixPosition;
    }
}