using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] private RectTransform MainPanel;
    [SerializeField] private RectTransform ControlsPanel;
    [SerializeField] private RectTransform AudioPanel;
    [SerializeField] private RectTransform CreditPanel;
    [SerializeField] private RectTransform exitPanel;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGameBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        SceneManager.LoadSceneAsync(GameConst.loaderSceneIndex);//load loading scene
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
        //MainPanel.gameObject.SetActive(false);
    }

    public void CreditsBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        CreditPanel.gameObject.SetActive(true);
        //MainPanel.gameObject.SetActive(false);
    }

    public void ExitBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        exitPanel.gameObject.SetActive(true);
        //MainPanel.gameObject.SetActive(false);

        //UnityEditor.EditorApplication.isPlaying = false;
        //in built ver
        //Application.Quit();
    }

    public void ReturnToMainBttn()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        MainPanel.gameObject.SetActive(true);
        AudioPanel.gameObject.SetActive(false);
        CreditPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(false);
        exitPanel.gameObject.SetActive(false);
    }
}
