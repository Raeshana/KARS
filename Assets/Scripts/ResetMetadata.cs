using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMetadata : MonoBehaviour
{
    private Metadata metadata;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

    void Start()
    {
        metadata.ResetMetadata();
    }
}
