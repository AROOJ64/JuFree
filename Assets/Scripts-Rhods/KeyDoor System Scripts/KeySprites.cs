using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySprites : MonoBehaviour
{
    public static KeySprites Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    //All key sprites
    public Sprite key1;
    public Sprite key2;
    public Sprite key3;
    public Sprite key4;
    public Sprite key5;
    public Sprite key6;
    public Sprite key7;
    public Sprite key8;

}
