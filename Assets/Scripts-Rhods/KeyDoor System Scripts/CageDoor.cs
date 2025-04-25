using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType _keyType;

    public Key.KeyType GetDoorKeyType()
    {
        return _keyType;
    }

    public void OpenCageDoor()
    {
        Debug.Log("Door open" +  _keyType);
        AudioManager.instance.PlaySFX("CageOpen");
    }
}
