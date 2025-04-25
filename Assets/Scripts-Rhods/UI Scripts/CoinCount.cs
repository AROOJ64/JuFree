using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class CoinCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTxt;


    //
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UpdateCoinCount();

    }

    public void UpdateCoinCount()
    {
        score = int.Parse(scoreTxt.text) + 1;
        scoreTxt.text = score.ToString();
    }
}
