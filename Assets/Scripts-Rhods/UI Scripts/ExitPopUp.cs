using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for levels

public class ExitPopUp : MonoBehaviour
{
    [SerializeField] PauseMenuUIManager _PauseUILvlManager;
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
            _PauseUILvlManager.PauseGameBttn();
            _isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _isPaused)
        {
            _PauseUILvlManager.ContinueGameBttn();
            _isPaused = false;
        }
    }
}
