using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChoiceSO", menuName = "ScriptableObjects/ChoiceSO", order = 1)]
public class ChoiceSO : ScriptableObject
{
    public string choice;
    public string[] dialogue;
}
