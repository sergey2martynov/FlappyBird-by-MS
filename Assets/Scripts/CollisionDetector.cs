using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    [SerializeField] private GameOverTextController _gameOverTextController;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void OnCollisionEnter2D()
    {
        _rigidbody2D.velocity = Vector2.zero;
        _gameController.IsGameOver = true;
        _gameOverTextController.ShowGameOverText();
    }
}