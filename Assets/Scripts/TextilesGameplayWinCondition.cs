using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextilesGameplayWinCondition : MonoBehaviour
{
    [SerializeField] 
    private Transform[] textiles;

    [SerializeField]
    private SceneController sceneController;

    private bool isAligned;

    private void Start()
    {
        isAligned = true;
    }

    public void EnterAnswer()
    {
        foreach (var textile in textiles) {
            if (textile.rotation.eulerAngles.z == 0) {
                isAligned = isAligned && true;
            }
            else {
                isAligned = isAligned && false;
            }
        }

        if (isAligned) {
            sceneController.TextilesGameplayWin();
        }     
        else {
            sceneController.TextilesGameplayLose();
        }   
    }
}
