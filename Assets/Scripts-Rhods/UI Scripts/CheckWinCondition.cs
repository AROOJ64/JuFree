using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWinCondition : MonoBehaviour
{
    [SerializeField] CageDoor[] cages;
    [SerializeField] Canvas WinCanvas;

    private int countCages = 0;
    private bool playerWon = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckCondition());
    }

    // Update is called once per frame
    void Update()
    {
        if (playerWon)
        {
            WinCanvas.gameObject.SetActive(true);
            playerWon = false;
        }
    }

    IEnumerator CheckCondition()
    {
        if (countCages == cages.Length  /*&& cages.Length != 0*/)
            playerWon = true;
        else
        {
            for (int i = 0; i < cages.Length; i++)
            {
                //if (cages[i].cageOpened)
                //{
                //    countCages++;
                //    Debug.Log("Counted Doors" + countCages + playerWon);
                //}
                //else
                //    countCages = 0;
            }
        }

        yield return new WaitForSeconds(0);
        StartCoroutine(CheckCondition());
    }
}
