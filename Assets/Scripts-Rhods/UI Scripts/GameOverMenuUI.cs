using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuUI : MonoBehaviour
{
    [SerializeField] private Canvas GameOverCanvas;

    private void Start()
    {
        
    }

    public void RestartLevel()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        GameOverCanvas.gameObject.SetActive(false);
        AudioManager.instance.PlayMusic("Theme");
        SceneManager.LoadSceneAsync(GameConst.lastSceneIndex);
    }

    public void ReturnToMainMenu()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        //Time.timeScale = 1.0f;
        AudioManager.instance.PlayMusic("Theme");
        SceneManager.LoadSceneAsync(1);
    }

}
