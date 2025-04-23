using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CriticSetup : MonoBehaviour
{
    [SerializeField] MetadataSO metadataSO;
    [SerializeField] TMP_Text quote;

    void Start()
    {
        quote.text = "'" + metadataSO.quote + "'";
    }
}
