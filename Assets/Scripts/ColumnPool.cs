using UnityEngine;
using Random = UnityEngine.Random;

public class ColumnPool : MonoBehaviour
{
    [SerializeField] private GameObject _columnPrefab;

    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;

    [SerializeField] private ScoreController _scoreController;

    private const float SpawnXPosition = 3.2f;
    private const float SpawnYMaxPosition = 3.2f;
    private const float SpawnYMinPosition = 1f;
    private const int ColumnPoolSize = 5;
    private const float SpawnRate = 4f;

    private GameObject[] _columns;
    private Vector2 _objectPoolPosition = new Vector2(-15f, -25f);
    private float _timeSienceLastSpawned;
    private int _currentColumn = 0;


    private void Start()
    {
        _columns = new GameObject[ColumnPoolSize];

        for (int i = 0; i < ColumnPoolSize; i++)
        {
            _columns[i] = (GameObject) Instantiate(_columnPrefab, _objectPoolPosition, Quaternion.identity);
            ColumnMovement columnMovement = _columns[i].GetComponent<ColumnMovement>();
            ColumnController columnController = _columns[i].GetComponent<ColumnController>();
            columnMovement.SendAPauseControllerReference(_pauseController);
            columnMovement.SendAGameControllerReference(_gameController);
            columnController.GettingAPoint += _scoreController.BirdScored;
        }
    }

    private void Update()
    {
        _timeSienceLastSpawned += Time.deltaTime;

        if (_gameController.IsGameOver == false && _timeSienceLastSpawned >= SpawnRate)
        {
            _timeSienceLastSpawned = 0;
            var spawnYPosition = Random.Range(SpawnYMinPosition, SpawnYMaxPosition);
            _columns[_currentColumn].transform.position = new Vector2(SpawnXPosition, spawnYPosition);
            _currentColumn++;
            if (_currentColumn >= ColumnPoolSize)
            {
                _currentColumn = 0;
            }
        }
    }
}