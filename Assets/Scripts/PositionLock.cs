using UnityEngine;

public class PositionLock : MonoBehaviour
{
    [SerializeField] private BirdController _birdController;

    [SerializeField] private Rigidbody2D _birdRigidbody2D;

    public void FixPosition()
    {
        _birdController.ConservationOfVelocity = _birdRigidbody2D.velocity;
        _birdRigidbody2D.velocity = Vector2.zero;
        _birdController.ConservationOfPosition = _birdRigidbody2D.transform.position;
        _birdRigidbody2D.isKinematic = true;
    }
}