using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testNext : MonoBehaviour
{
   public void LoadSceneLoader()
    {
        SceneManager.LoadSceneAsync(GameConst.loaderSceneIndex);
    }
}
