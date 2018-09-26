using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [SerializeField] SceneAsset startScene;
    [SerializeField] SceneAsset gameOverScene;

    public void LoadStartScene()
    {
        SceneManager.LoadScene(startScene.name);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(gameOverScene.name);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
