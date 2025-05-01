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

    public void PhotogramGameplayWin() {
        SceneManager.LoadScene("PhotogramGameplayWin", LoadSceneMode.Additive);
    }

    public void ClosePhotogramGameplayWin() {
        SceneManager.UnloadSceneAsync("PhotogramGameplayWin");
    }    

    public void PhotogramGameplayLose() {
        SceneManager.LoadScene("PhotogramGameplayLose", LoadSceneMode.Additive);
    }

    public void ClosePhotogramGameplayLose() {
        SceneManager.UnloadSceneAsync("PhotogramGameplayLose");
    }    

    public void PhotogramGameplayScene() {
        SceneManager.LoadScene("PhotogramGameplayScene", LoadSceneMode.Single);
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

    public void GoToEndingScene() {
        SceneManager.LoadScene("EndingScene", LoadSceneMode.Single);
    }

    public void GoToWinEndingScene() {
        SceneManager.LoadScene("WinEndingScene", LoadSceneMode.Single);
    }

    public void GoToCriticEndingScene() {
        SceneManager.LoadScene("CriticEndingScene", LoadSceneMode.Single);
    }

    public void GoToReplayScene() {
        SceneManager.LoadScene("ReplayScene", LoadSceneMode.Single);
    }

    public void GoToSelectionScene() {
        SceneManager.LoadScene("SelectionScene", LoadSceneMode.Single);
    }

    public void GoToTimeTravelScene() {
        SceneManager.LoadScene("TimeTravelScene", LoadSceneMode.Single);
    }

    public void GoToExhibitionScene() {
        SceneManager.LoadScene("ExhibitionScene", LoadSceneMode.Single);
    }

    [ContextMenu("Overlays photogram theory scene")]
    public void GoToPhotogramTheoryScene() {
        SceneManager.LoadScene("PhotogramTheorySceneAdd", LoadSceneMode.Additive);
    }

    [ContextMenu("Closes photogram theory scene")]
    public void ClosePhotogramTheoryScene() {
        SceneManager.UnloadSceneAsync("PhotogramTheorySceneAdd");
    }

    public void PhotogramTheoryScene() {
        if (SceneManager.GetSceneByName("PhotogramTheorySceneAdd").isLoaded) {
            ClosePhotogramTheoryScene();
        }
        else {
            GoToPhotogramTheoryScene();
        }
    }

    [ContextMenu("Overlays textiles theory scene")]
    public void GoToTextilesTheoryScene() {
        SceneManager.LoadScene("TextilesTheorySceneAdd", LoadSceneMode.Additive);
    }

    [ContextMenu("Closes photogram theory scene")]
    public void CloseTextilesTheoryScene() {
        SceneManager.UnloadSceneAsync("TextilesTheorySceneAdd");
    }

    public void TextilesTheoryScene() {
        if (SceneManager.GetSceneByName("TextilesTheorySceneAdd").isLoaded) {
            CloseTextilesTheoryScene();
        }
        else {
            GoToTextilesTheoryScene();
        }
    }
}
