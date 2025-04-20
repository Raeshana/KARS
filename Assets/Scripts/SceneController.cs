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
        // StartCoroutine(GoToNextSceneRoutine());
    }

    private IEnumerator GoToNextSceneRoutine()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        int next = current + 1;

        yield return new WaitForSeconds(0.35f);

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
}
