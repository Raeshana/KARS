using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveQuote : MonoBehaviour
{
    private Metadata metadata;
    [SerializeField] TMP_Text quoteText;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

    public void SaveQuoteButton()
    {
        metadata.UpdateQuote(quoteText.text);
    }
}
