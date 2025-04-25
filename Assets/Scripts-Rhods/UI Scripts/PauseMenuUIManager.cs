using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUIManager : MonoBehaviour
{
    [SerializeField] private Canvas PauseCanvas;
   // [SerializeField] private RectTransform PauseMenuPanel;
    [SerializeField] private RectTransform MainPanel;
    [SerializeField] private RectTransform ControlsPanel;
    [SerializeField] private RectTransform AudioPanel;
    [SerializeField] private RectTransform exitPanel;

    public void PauseGameBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        Time.timeScale = 0f;
        //set any player/input script as false
        PauseCanvas.gameObject.SetActive(true);
    }

    public void ContinueGameBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        Time.timeScale = 1.0f;
        PauseCanvas.gameObject.SetActive(false);
    }

    public void ControlsBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        ControlsPanel.gameObject.SetActive(true);
        MainPanel.gameObject.SetActive(false);
    }

    public void AudioBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        AudioPanel.gameObject.SetActive(true);
        MainPanel.gameObject.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        Time.timeScale = 1.0f;
        //Reset the scripts
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        exitPanel.gameObject.SetActive(true);
        MainPanel.gameObject.SetActive(false);

        //UnityEditor.EditorApplication.isPlaying = false;
        //in built ver
        //Application.Quit();
    }

    public void ReturnToMainPanelBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        MainPanel.gameObject.SetActive(true);
        AudioPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(false);
    }
}
