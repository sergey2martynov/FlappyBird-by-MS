using UnityEngine;

public static class ExtensionForColumnMovement
{
    public static void ChangeTheSpeed(this Rigidbody2D rb2D, Vector2 vector2)
    {
        rb2D.velocity = vector2;
    }
}