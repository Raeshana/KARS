using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateExhibition : MonoBehaviour
{
    private Metadata metadata;

    [Header("Replacement Sprites")]
    [SerializeField] Sprite act1Sprite;
    [SerializeField] Sprite act2Sprite;
    [SerializeField] Sprite act3Sprite;

    [Header("Sprite Placeholders")]
    [SerializeField] Image act1Image;
    [SerializeField] Image act2Image;
    [SerializeField] Image act3Image;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (metadata.act1) {
            act1Image.sprite = act1Sprite;
        }

        if (metadata.act2) {
            act2Image.sprite = act2Sprite;
        }

        if (metadata.act3) {
            act3Image.sprite = act3Sprite;
        }
    }
}
