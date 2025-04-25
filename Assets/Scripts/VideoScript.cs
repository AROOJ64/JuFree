using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player.loopPointReached += LoadMenu;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LoadMenu(VideoPlayer vidP)
    {
        SceneManager.LoadScene(1);
    }
}