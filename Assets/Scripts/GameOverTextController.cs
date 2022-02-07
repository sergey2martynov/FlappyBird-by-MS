using TMPro;
using UnityEngine;

public class GameOverTextController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverText;

    [SerializeField] private GameObject _scoreResult;

    [SerializeField] private TMP_Text _scoreTextResult;

    [SerializeField] private ScoreController _scoreController;

    public void ShowGameOverText()
    {
        _scoreTextResult.text = _scoreController.ReturnScoreText.text;
        SetGameOverTextActive(true);
    }

    private void SetGameOverTextActive(bool isActive)
    {
        _gameOverText.SetActive(isActive);
        _scoreResult.SetActive(isActive);
    }
}