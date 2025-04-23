using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMetadata : MonoBehaviour
{
    [SerializeField] MetadataSO metadataSO;

    // Start is called before the first frame update
    void Start()
    {
        metadataSO.act1 = false;
        metadataSO.act2 = false;
        metadataSO.act3 = false;
        metadataSO.quote = "";
    }
}
