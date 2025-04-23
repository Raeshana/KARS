using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWinCondition : MonoBehaviour
{
    [SerializeField] MetadataSO metadataSO;
    [SerializeField] SceneController sceneController;

    public void FinalButton() {
        if (metadataSO.act1 & metadataSO.act2 & metadataSO.act3) {
            sceneController.GoToWinEndingScene();
        }
        else {
            sceneController.GoToCriticEndingScene();
        }
    }
}
