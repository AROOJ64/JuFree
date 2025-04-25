using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType _keyType;
    public enum KeyType
    {
        key1, key2, key3, key4, key5, key6, key7, key8
    }

    public KeyType GetKeyType()
    {
        return _keyType;
    }

    public Sprite GetSprite()
    {
        switch(_keyType)
        {
            default:
            case KeyType.key1: return KeySprites.Instance.key1;
            case KeyType.key2: return KeySprites.Instance.key2;
            case KeyType.key3: return KeySprites.Instance.key3;
            case KeyType.key4: return KeySprites.Instance.key4;
            case KeyType.key5: return KeySprites.Instance.key5;
            case KeyType.key6: return KeySprites.Instance.key6;
            case KeyType.key7: return KeySprites.Instance.key7;
            case KeyType.key8: return KeySprites.Instance.key8;
        }
    }
}
