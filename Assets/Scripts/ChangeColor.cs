using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private Image paint;

    public void AddColor(Color addedColor) {
        Color newColor = addedColor/10;
        newColor.a = 1;

        if (paint.color == Color.white)
        {
            paint.color = newColor;
        }
        else paint.color = paint.color + newColor;
    }

    public void AddRed() {
        Color newColor = paint.color;
        newColor.g = newColor.g - 0.1f;
        newColor.b = newColor.b - 0.1f;
        paint.color = newColor;
    }

    public void AddBlue() {
        Color newColor = paint.color;
        newColor.g = newColor.g - 0.1f;
        newColor.r = newColor.r - 0.1f;
        paint.color = newColor;
    }

    public void AddGreen() {
        Color newColor = paint.color;
        newColor.r = newColor.r - 0.1f;
        newColor.b = newColor.b - 0.1f;
        paint.color = newColor;
    }

    public void AddWhite() {
        Color newColor = paint.color;
        newColor.r = newColor.g + 0.1f;
        newColor.g = newColor.g + 0.1f;
        newColor.b = newColor.b + 0.1f;
        paint.color = newColor;
    }
}
