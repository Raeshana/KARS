using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSceneSetup : MonoBehaviour
{
    [Header("Scriptable Objects")]
    [SerializeField] CharacterSO character;

    [Header("Speech Bubble")]
    [SerializeField] TMP_Text speechBubble;
    [SerializeField] TMP_Text choice1;
    [SerializeField] TMP_Text choice2;

    [Header("Background")]
    [SerializeField] Image backgroundImage;

    [Header("Character")]
    [SerializeField] TMP_Text characterTitle;
    [SerializeField] Image characterImage;

    [Header("Buttons")]
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject choice1Button;
    [SerializeField] GameObject choice2Button;
    [SerializeField] GameObject nextSceneButton1;
    [SerializeField] GameObject nextSceneButton2;

    private string[] dialogue;
    private int count;
    private int imageMax;
    
    void Start()
    {
        // Setup speech bubble
        speechBubble.text = character.dialogue[0];
        choice1.text = character.choice1.choice;
        choice2.text = character.choice2.choice;

        // Setup character information
        characterTitle.text = character.title;
        characterImage.sprite = character.image[0];
        imageMax = character.image.Length;

        // Setup background information
        backgroundImage.sprite = character.background;

        // Populate dialogue
        dialogue = new string[4];
        dialogue[0] = character.dialogue[0];
        dialogue[1] = character.dialogue[1];
        count = 0;
    }

    private void ChangeSprite() {
        int num = Mathf.FloorToInt (Random.Range(0, imageMax));
        characterImage.sprite = character.image[num]; 
    }

    /// <summary>
    /// Increments dialogue
    /// Might change character sprite
    /// Enables next button
    /// Disables back button
    /// </summary>
    public void Next() {
        count++;
        speechBubble.text = dialogue[count];

        ChangeSprite();

        nextButton.SetActive(false);
        backButton.SetActive(true);
    }

    /// <summary>
    /// Decrements dialogue
    /// Might change character sprite
    /// Disables next button
    /// Enables back button
    /// </summary>
    public void Back() {
        count--;
        speechBubble.text = dialogue[count];

        ChangeSprite();

        nextButton.SetActive(true);
        backButton.SetActive(false);
    }

    /// <summary>
    /// Changes dialogue to choice options
    /// Might change character sprite
    /// Enables next button
    /// Disables back button
    /// Disables choice buttons
    /// Enables next scene button
    /// </summary>
    private void Choice() {
        // Update dialogue
        count = 2;
        speechBubble.text = dialogue[count];

        // Update character sprite
        ChangeSprite();

        // Enable next button, disable back button
        nextButton.SetActive(true);
        backButton.SetActive(false);

        // Remove choice buttons
        choice1Button.SetActive(false);
        choice2Button.SetActive(false);
    }

    /// <summary>
    /// Adds choice 1 dialogue to dialogue array
    /// Calls choice to  update interface
    /// </summary>
    public void Choice1() {
        // Update dialogue
        dialogue[2] =  character.choice1.dialogue[0];
        dialogue[3] = character.choice1.dialogue[1];
        
        Choice ();
        // Enables next scene button
        nextSceneButton1.SetActive(true);
    }

    /// <summary>
    /// Adds choice 2 dialogue to dialogue array
    /// Calls choice to  update interface
    /// </summary>
    public void Choice2() {
        // Update dialogue
        dialogue[2] =  character.choice2.dialogue[0];
        dialogue[3] = character.choice2.dialogue[1];

        Choice ();
        nextSceneButton2.SetActive(true);
    }
}
