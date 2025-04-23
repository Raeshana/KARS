using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextilesGameplayWinCondition : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] textiles;

    [SerializeField]
    private SceneController sceneController;

    [SerializeField] MetadataSO metadataSO;

    private bool isAligned;

    private void Start()
    {
        isAligned = true;
    }

    public void EnterAnswer()
    {
        foreach (var textile in textiles) {
            if (textile.transform.rotation.eulerAngles.z <= 0) {
                isAligned = isAligned && true;
            }
            else {
                isAligned = isAligned && false;
            }
        }

        if (isAligned) {
            sceneController.TextilesGameplayWin();
            metadataSO.act3 = true;
        }     
        else {
            sceneController.TextilesGameplayLose();
            metadataSO.act3 = false;
        }   
    }
}
