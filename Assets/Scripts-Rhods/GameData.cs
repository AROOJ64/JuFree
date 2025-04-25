using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
  
    [SerializeField] Texture2D cursorArrowIdle;
    //[SerializeField] Texture2D cursorArrowHover;
    //[SerializeField] Texture2D cursorArrowClick;

    // Start is called before the first frame update
    void Start()
    {
        GameConst.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Cursor.SetCursor(cursorArrowIdle, Vector2.zero, CursorMode.ForceSoftware);
        
    }

    private void Update()
    {
        
    }

    //private void OnMouseEnter()
    //{
    //    Cursor.SetCursor(cursorArrowHover, Vector2.zero, CursorMode.ForceSoftware);
    //}

    //private void OnMouseExit()
    //{
    //    Cursor.SetCursor(cursorArrowIdle, Vector2.zero, CursorMode.ForceSoftware);
    //}

    //private void OnMouseDown()
    //{
    //    Cursor.SetCursor(cursorArrowClick, Vector2.zero, CursorMode.ForceSoftware);
    //}
}
