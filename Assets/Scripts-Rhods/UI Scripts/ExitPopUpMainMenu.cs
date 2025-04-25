using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopUpMainMenu : MonoBehaviour
{
    [SerializeField] MainMenuUIManager _MainUILvlManager;
    bool _isPaused;
    // Start is called before the first frame update
    void Start()
    {
        _isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_isPaused)
        {
            _MainUILvlManager.ExitBttn();
            _isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _isPaused)
        {
            _MainUILvlManager.ReturnToMainBttn();
            _isPaused = false;
        }
    }
}
