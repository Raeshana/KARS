using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "ScriptableObjects/CharacterSO", order = 1)]
public class CharacterSO : ScriptableObject
{
    public Sprite background;
    public Sprite[] image;
    public string title;
    public string[] dialogue;
    public ChoiceSO choice1;
    public ChoiceSO choice2;
}
