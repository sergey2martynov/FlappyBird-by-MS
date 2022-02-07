using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private BirdCollisionDetectorWithColumn _birdCollisionDetectorWithColumn;

    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField] private GameController _gameController;

    [SerializeField] private GameOverTextController _gameOverTextController;

    private void Start()
    {
        _birdCollisionDetectorWithColumn.СollisionOfABirdWithColumns += FinishTheGame;
    }

    private void FinishTheGame()
    {
        _rigidbody2D.velocity = Vector2.zero;
        _gameController.IsGameOver = true;
        _gameOverTextController.ShowGameOverText();
    }
}