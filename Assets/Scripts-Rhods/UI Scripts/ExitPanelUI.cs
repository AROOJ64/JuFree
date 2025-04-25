using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanelUI : MonoBehaviour
{
    [SerializeField] private RectTransform MainPanel;
    [SerializeField] private RectTransform exitPanel;
    public void YesButton()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        UnityEditor.EditorApplication.isPlaying = false;
        //in built ver
        //Application.Quit();
    }

    public void NoButton()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
        exitPanel.gameObject.SetActive(false);
        MainPanel.gameObject.SetActive(true);
    }
}
