using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metadata : MonoBehaviour
{
    public bool act1;
    public bool act2;
    public bool act3;
    public string quote;
    
    void Start()
    {
        ResetMetadata();
    }

    public void ResetMetadata() {
        act1 = false;
        act2 = false;
        act3 = false;
        quote = "";
    } 

    public void SetAct1ToTrue() {
        act1 = true;
    }

    public void SetAct2ToTrue() {
        act2 = true;
    }

    public void SetAct3ToTrue() {
        act3 = true;
    }

    public void SetAct1ToFalse() {
        act1 = false;
    }

    public void SetAct2ToFalse() {
        act2 = false;
    }

    public void SetAct3ToFlase() {
        act3 = false;
    }

    public void UpdateQuote(string words) {
        quote = words;
    }
}
