using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [ContextMenu("Transition to next scene")]
    public void GoToNextScene() 
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        int next = current + 1;
        SceneManager.LoadScene(next, LoadSceneMode.Single);
    }

    [ContextMenu("Overlays color theory scene")]
    public void GoToColorTheoryScene() {
        SceneManager.LoadScene("ColorTheorySceneAdd", LoadSceneMode.Additive);
    }

    [ContextMenu("Closes color theory scene")]
    public void CloseColorTheoryScene() {
        SceneManager.UnloadSceneAsync("ColorTheorySceneAdd");
    }

    public void ColorTheoryScene() {
        if (SceneManager.GetSceneByName("ColorTheorySceneAdd").isLoaded) {
            CloseColorTheoryScene();
        }
        else {
            GoToColorTheoryScene();
        }
    }

    public void ColorGameplayWin() {
        SceneManager.LoadScene("ColorGameplayWin", LoadSceneMode.Additive);
    }

    public void CloseColorGameplayWin() {
        SceneManager.UnloadSceneAsync("ColorGameplayWin");
    }

    public void ColorGameplayLose() {
        SceneManager.LoadScene("ColorGameplayLose", LoadSceneMode.Additive);
    }

    public void CloseColorGameplayLose() {
        SceneManager.UnloadSceneAsync("ColorGameplayLose");
    }

    public void ColorGameplayScene() {
        SceneManager.LoadScene("ColorGameplayScene", LoadSceneMode.Single);
    }

    public void GoToAct2() {
        SceneManager.LoadScene("Act2HeaderScene", LoadSceneMode.Single);
    }

    public void GoToAct3() {
        SceneManager.LoadScene("Act3HeaderScene", LoadSceneMode.Single);
    }

    public void TextilesGameplayWin() {
        SceneManager.LoadScene("TextilesGameplayWin", LoadSceneMode.Additive);
    }

    public void CloseTextilesGameplayWin() {
        SceneManager.UnloadSceneAsync("TextilesGameplayWin");
    }

    public void TextilesGameplayLose() {
        SceneManager.LoadScene("TextilesGameplayLose", LoadSceneMode.Additive);
    }

    public void CloseTextilesGameplayLose() {
        SceneManager.UnloadSceneAsync("TextilesGameplayLose");
    }

    public void TextilesGameplayScene() {
        SceneManager.LoadScene("TextilesGameplayScene", LoadSceneMode.Single);
    }
}
