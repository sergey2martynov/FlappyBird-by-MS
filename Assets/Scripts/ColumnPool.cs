using UnityEngine;
using Random = UnityEngine.Random;

public class ColumnPool : MonoBehaviour
{
    [SerializeField] private GameObject _columnPrefab;

    [SerializeField] private GameObject _spawnPoolObject;

    [SerializeField] private GameController _gameController;

    [SerializeField] private PauseController _pauseController;

    [SerializeField] private ScoreController _scoreController;

    [SerializeField] private float _spawnXPosition = 3.2f;
    [SerializeField] private float _spawnYMaxPosition = 3.2f;
    [SerializeField] private float _spawnYMinPosition = 1f;
    [SerializeField] private float _spawnRate = 4f;

    [SerializeField] private int _columnPoolSize = 5;

    private ColumnController[] _columns;


    private float _timeSienceLastSpawned;

    private int _currentColumn = 0;

    private void Start()
    {
        _columns = new ColumnController[_columnPoolSize];

        for (int i = 0; i < _columnPoolSize; i++)
        {
            var spawnColumn = Instantiate(_columnPrefab, _spawnPoolObject.transform.position, Quaternion.identity);
            _columns[i] = spawnColumn.GetComponent<ColumnController>();;
            var columnMovement = _columns[i].GetComponent<ColumnMovement>();
            columnMovement.Inject(_gameController, _pauseController);
            _columns[i].TheBirdFlewThroughTheHole += _scoreController.BirdScored;
        }
    }

    private void Update()
    {
        if (!_pauseController.СheckIfTheGameIsPaused())
        {
            _timeSienceLastSpawned += Time.deltaTime;
        }

        if (!_gameController.IsGameOver && _timeSienceLastSpawned >= _spawnRate)
        {
            _timeSienceLastSpawned = 0;
            var spawnYPosition = Random.Range(_spawnYMinPosition, _spawnYMaxPosition);
            _columns[_currentColumn].SetPosition(_spawnXPosition, spawnYPosition);
            _currentColumn++;
            if (_currentColumn >= _columnPoolSize)
            {
                _currentColumn = 0;
            }
        }
    }
}