using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUIMenu : MonoBehaviour
{
    [SerializeField] private Canvas WinCanvas;
    public void NextLevelBttn()
    {
        WinCanvas.gameObject.SetActive(false);
        AudioManager.instance.PlaySFX("ButtonClick");
        SceneManager.LoadSceneAsync(GameConst.loaderSceneIndex);
    }

    public void ReturnToMainMenu()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        SceneManager.LoadSceneAsync(1);
    }

}
