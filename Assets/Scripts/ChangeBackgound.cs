using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackgound : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Image background;
    [SerializeField] Sprite[] image;

    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject nextSceneButton;

    private int count;

    void Start()
    {
        count = 0;
    }

    /// <summary>
    /// Change background image to next image
    /// Disables next button
    /// Enables back button
    /// Enables next scene button
    /// </summary>
    public void Next() {
        count++;
        background.sprite = image[count];
        nextButton.SetActive(false);
        backButton.SetActive(true);
        nextSceneButton.SetActive(true);
    }

    /// <summary>
    /// Change background image to next image
    /// Enables next button
    /// Disables back button
    /// Disables next scene button
    /// </summary>
    public void Back() {
        count--;
        background.sprite = image[count];
        nextButton.SetActive(true);
        backButton.SetActive(false);
        nextSceneButton.SetActive(false);
    }
}
