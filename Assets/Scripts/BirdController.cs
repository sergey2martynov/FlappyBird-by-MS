using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;

    [SerializeField] private PositionLock _positionLock;

    [SerializeField] private ResumptionOfMovement _resumptionOfMovement;

    [SerializeField] private BirdJumper _birdJumper;

    [SerializeField] private PauseController _pauseController;

    public Vector2 ConservationOfVelocity { get; set; }

    public Vector2 ConservationOfPosition { get; set; }


    private void Start()
    {
        _inputManager.SpacePressed += _birdJumper.Jump;

        _pauseController.PauseIsTrue += _positionLock.FixPosition;

        _pauseController.PauseIsFalse += _resumptionOfMovement.KeepMoving;
    }

    private void Update()
    {
        if (_pauseController.IsPause)
        {
            transform.position = ConservationOfPosition;
        }
    }
}