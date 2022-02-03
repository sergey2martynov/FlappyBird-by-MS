using System;
using UnityEngine;

public class ColumnController : MonoBehaviour
{
    public event Action GettingAPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BirdController>() != null)
        {
            GettingAPoint?.Invoke();
        }
    }
}