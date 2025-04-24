using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightPhotogram : MonoBehaviour
{
    [SerializeField] Image[] photogramObjects;
    [SerializeField] Sprite[] whiteObjects;

    public void ChangeSprite() {
        for (int i = 0; i < photogramObjects.Length; i++) {
            photogramObjects[i].sprite = whiteObjects[i];
        }
    }
}
