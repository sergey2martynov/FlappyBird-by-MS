using UnityEngine;

public class ResumptionOfMovement : MonoBehaviour
{
    [SerializeField] private BirdController _birdController;

    [SerializeField] private Rigidbody2D _birdRigidbody2D;

    public void KeepMoving()
    {
        _birdRigidbody2D.isKinematic = false;
        _birdRigidbody2D.velocity = _birdController.ConservationOfVelocity;
    }
}