using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "ScriptableObjects/CharacterSO", order = 1)]
public class CharacterSO : ScriptableObject
{
    public Sprite image1;
    public Sprite image2;
    public string title;
    public string[] dialogue;
    public ChoiceSO choice1;
    public ChoiceSO choice2;
}
