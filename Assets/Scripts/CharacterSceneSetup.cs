using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSceneSetup : MonoBehaviour
{
    [SerializeField] CharacterSO character;

    [SerializeField] TMP_Text speechBubble;
    [SerializeField] TMP_Text choice1;
    [SerializeField] TMP_Text choice2;

    [SerializeField] TMP_Text characterTitle;
    [SerializeField] Image characterImage;
    
    void Start()
    {
        // Setup speech bubble
        speechBubble.text = character.dialogue[0];
        choice1.text = character.choice1.choice;
        choice2.text = character.choice2.choice;

        // Setup character information
        characterTitle.text = character.title;
        characterImage.sprite = character.image1;
    }
}
