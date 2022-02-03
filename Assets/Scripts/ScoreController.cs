using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    [SerializeField] private GameController _gameController;

    private int _score = 0;

    public void BirdScored()
    {
        if (_gameController.IsGameOver)
        {
            return;
        }

        _score++;
        _scoreText.text = "Score: " + _score;
    }

    public TextMeshProUGUI ReturnScoreText()
    {
        return _scoreText;
    }
}