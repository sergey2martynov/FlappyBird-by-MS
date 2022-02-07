using System;
using UnityEngine;

public class BirdCollisionDetectorWithColumn : MonoBehaviour
{
    public event Action СollisionOfABirdWithColumns;

    private void OnCollisionEnter2D()
    {
        СollisionOfABirdWithColumns?.Invoke();
        
    }
}