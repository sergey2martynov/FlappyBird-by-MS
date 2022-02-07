using System;
using UnityEngine;

public class BirdCollisionWithColumnDetector : MonoBehaviour
{
    public event Action BirdCollidedWithColumn;

    private void OnCollisionEnter2D()
    {
        BirdCollidedWithColumn?.Invoke();
    }
}