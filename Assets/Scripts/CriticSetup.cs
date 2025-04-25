using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CriticSetup : MonoBehaviour
{
    private Metadata metadata;
    [SerializeField] TMP_Text quote;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

    void Start()
    {
        quote.text = "'" + metadata.quote + "'";
    }
}
