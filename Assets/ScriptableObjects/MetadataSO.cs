using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "MetadataSO", menuName = "ScriptableObjects/MetadataSO", order = 1)]
public class MetadataSO : ScriptableObject
{
    public bool act1;
    public bool act2;
    public bool act3;
    public string quote;
}
