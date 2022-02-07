using System;
using UnityEngine;

public class ColumnController : MonoBehaviour
{
    [SerializeField] private GameObject _column;
    public event Action TheBirdFlewThroughTheHole;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bird")
        {
            TheBirdFlewThroughTheHole?.Invoke();
        }
    }

    public void SetPosition(float spawnXPosition, float spawnYPosition)
    {
        _column.transform.position = new Vector2(spawnXPosition, spawnYPosition);
    }
}