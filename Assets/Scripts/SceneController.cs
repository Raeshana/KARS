using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [ContextMenu("Transition to next scene")]
    public void GoToNextScene() 
    {
        StartCoroutine(GoToNextSceneRoutine());
    }

    private IEnumerator GoToNextSceneRoutine()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        int next = current + 1;

        yield return new WaitForSeconds(0.35f);

        SceneManager.LoadScene(next, LoadSceneMode.Single);
    }

    [ContextMenu("Go to act 1 info scene")]
    public void GoToAct1InfoScene()
    {
        SceneManager.LoadScene("Act1InfoScene", LoadSceneMode.Single);
    }

    [ContextMenu("Go to color theory scene")]
    public void GoToColorTheoryScene()
    {
        SceneManager.LoadScene("ColorTheoryScene", LoadSceneMode.Single);
    }

    [ContextMenu("Go to color gameplay scene")]
    public void GoToColorGameplayScene()
    {
        SceneManager.LoadScene("ColorGameplayScene", LoadSceneMode.Single);
    }
}
