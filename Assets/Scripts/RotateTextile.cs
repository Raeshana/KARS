using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTextile : MonoBehaviour
{
    private float[] rotations;

    void Start()
    {
        // Populate rotations
        rotations = new float[3];
        rotations[0] = -90f;
        rotations[1] = -180f;
        rotations[2] = -270f;

        // Get random rotation
        int rotation = Mathf.FloorToInt (Random.Range(0, 2));
        transform.Rotate(0.0f, 0.0f, rotations[rotation], Space.Self);
    }

    /// <summary>
    /// Rotate textile 90 deg to the right
    /// </summary>
    public void Rotate() {
        transform.Rotate(0.0f, 0.0f, -90f, Space.Self);
    }
}
