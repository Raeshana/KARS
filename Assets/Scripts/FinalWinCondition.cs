using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWinCondition : MonoBehaviour
{
    [SerializeField] Metadata metadata;
    [SerializeField] SceneController sceneController;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

    public void FinalButton() {
        if (metadata.act1 && metadata.act2 || 
            metadata.act1 && metadata.act3 ||
            metadata.act2 && metadata.act3) {
            sceneController.GoToWinEndingScene();
        }
        else {
            sceneController.GoToCriticEndingScene();
        }
    }
}
