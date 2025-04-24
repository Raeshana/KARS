using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertPhotogram : MonoBehaviour
{
    [SerializeField] Image photogramObject;

    public void EnableObject() {
        photogramObject.gameObject.SetActive(true);
    }
}
