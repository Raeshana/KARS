using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateExhibition : MonoBehaviour
{
    [SerializeField] MetadataSO metadataSO;

    [Header("Replacement Sprites")]
    [SerializeField] Sprite act1Sprite;
    [SerializeField] Sprite act2Sprite;
    [SerializeField] Sprite act3Sprite;

    [Header("Sprite Placeholders")]
    [SerializeField] Image act1Image;
    [SerializeField] Image act2Image;
    [SerializeField] Image act3Image;

    // Start is called before the first frame update
    void Start()
    {
        if (metadataSO.act1) {
            act1Image.sprite = act1Sprite;
        }

        if (metadataSO.act2) {
            act2Image.sprite = act2Sprite;
        }

        if (metadataSO.act3) {
            act3Image.sprite = act3Sprite;
        }
    }
}
