using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightPhotogram : MonoBehaviour
{
    [SerializeField] Image[] photogramObjects;
    [SerializeField] Sprite[] photogramSprites;
    [SerializeField] Sprite[] whiteObjects;
    [SerializeField] bool[] bauhausObjects;

    [SerializeField] SceneController sceneController;
    [SerializeField] MetadataSO metadataSO;

    private bool isBauhausObject;

    void Start()
    {
        isBauhausObject = true;
        for (int i = 0; i < photogramObjects.Length; i++) {
            photogramObjects[i].sprite = photogramSprites[i];
            photogramObjects[i].gameObject.SetActive(false);
        }
    }

    public void ChangeSprite() {
        for (int i = 0; i < photogramObjects.Length; i++) {
            if (photogramObjects[i].gameObject.activeSelf) {
                photogramObjects[i].sprite = whiteObjects[i];
            }   
        }
    }

    public void WinCondition() {
         StartCoroutine(WinConditionRoutine());
    }

    private IEnumerator WinConditionRoutine() {
        yield return new WaitForSeconds(0.3f);

        for (int i = 0; i < photogramObjects.Length; i++) {
            if (photogramObjects[i].gameObject.activeSelf == bauhausObjects[i]) {
                isBauhausObject = isBauhausObject && true;
            }
            else {
                isBauhausObject = isBauhausObject && false;
            }
        }

        if (isBauhausObject) {
            sceneController.PhotogramGameplayWin();
            metadataSO.act2 = true;
        }
        else {
            sceneController.PhotogramGameplayLose();
            metadataSO.act2 = false;
        }
    }
}
