using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private const float BackgroundVanishingPoint = -8.74f;

    private const float BackgroundAppearancePoint = 8.51f;

    private void Update()
    {
        if (transform.position.x < BackgroundVanishingPoint)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        transform.position = new Vector2(BackgroundAppearancePoint, 0);
    }
}