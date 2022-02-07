using System;
using UnityEngine;

public class ResumptionOfMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _birdRigidbody2D;

    [SerializeField] private PositionLock _positionLock;

    [SerializeField] private PauseController _pauseController;

    private void Start()
    {
        _pauseController.GameIsUnpaused += KeepMoving;
    }

    private void KeepMoving()
    {
        _birdRigidbody2D.isKinematic = false;
        _birdRigidbody2D.velocity = _positionLock.ConservationOfVelocity;
    }

    private void OnDestroy()
    {
        _pauseController.GameIsUnpaused -= KeepMoving;
    }
}