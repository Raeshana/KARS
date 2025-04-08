using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
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
