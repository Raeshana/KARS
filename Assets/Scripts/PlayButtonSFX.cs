using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonSFX : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;

    public void PlaySFX() {
        audioManager.PlaySFX(audioManager.button);
    }
}
