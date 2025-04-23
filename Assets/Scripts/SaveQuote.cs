using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveQuote : MonoBehaviour
{
    [SerializeField] MetadataSO metadataSO;
    [SerializeField] TMP_Text quoteText;

    public void SaveQuoteButton()
    {
        metadataSO.quote = quoteText.text;
    }
}
