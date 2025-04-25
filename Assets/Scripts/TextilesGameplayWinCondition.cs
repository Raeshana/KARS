using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextilesGameplayWinCondition : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] textiles;

    [SerializeField]
    private SceneController sceneController;

    private Metadata metadata;

    private bool isAligned;

    void Awake()
    {
        metadata = GameObject.FindWithTag("Metadata").GetComponent<Metadata>();
    }

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
            metadata.SetAct3ToTrue();
        }     
        else {
            sceneController.TextilesGameplayLose();
            metadata.SetAct3ToFlase();
        }   
    }
}
