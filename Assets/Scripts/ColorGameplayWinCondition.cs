using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorGameplayWinCondition : MonoBehaviour
{
    [SerializeField]
    private Image paint;

    [SerializeField] 
    private SceneController sceneController;

    [SerializeField]
    private Button hintButton;
    [SerializeField]
    private Button enterButton;

    private void DisableButtons() {
        hintButton.interactable = false;
        enterButton.interactable = false;   
    }

    private void LoadWinScene() {
        DisableButtons();
        sceneController.ColorGameplayWin();
    }

    private void LoadLoseScene() {
        DisableButtons();
        sceneController.ColorGameplayLose();
    }

    public void EnterAnswer() {
        float red = paint.color.r;
        float green = paint.color.g;
        float blue = paint.color.b;
        if (blue >= (100/255) & green <= (80/255) && red <= (80/255)) {
            LoadWinScene();
        }
        else {
            LoadLoseScene();
        }
    }
}
