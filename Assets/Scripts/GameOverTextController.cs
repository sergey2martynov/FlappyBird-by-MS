using TMPro;
using UnityEngine;

public class GameOverTextController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverText;

    [SerializeField] private GameObject _scoreResult;

    [SerializeField] private TextMeshProUGUI _scoreTextResult;

    [SerializeField] private ScoreController _scoreController;

    public void ShowGameOverText()
    {
        _scoreTextResult.text = _scoreController.ReturnScoreText().text;
        _gameOverText.SetActive(true);
        _scoreResult.SetActive(true);
    }
}