using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;

    private List<Key> _keyList;
    CageDoor _Door;
    bool standNearDoor;
    bool doorOpened;

    private void Awake()
    {
        _keyList = new List<Key>();
        standNearDoor = false;
        doorOpened = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q) && standNearDoor)
            KeyOpendCage();
    }
    public void AddKey(Key _keyType)
    {
        Debug.Log("Added Key");
        _keyList.Add(_keyType);
        //AudioManager.instance.PlaySFX("PickupKey");
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKey(Key _keyType)
    {
        _keyList.Remove(_keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Key> GetKeyList()
    {
        return _keyList;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag(GameConst.keyTag))
        {
            Key _key = collision.GetComponent<Key>();
            AddKey(_key);
            Destroy(_key.gameObject);
        }

       
        if (collision.CompareTag(GameConst.cageDoorTag))
        {
            _Door = collision.GetComponent<CageDoor>();
            standNearDoor = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        standNearDoor = false;
    }

    public void KeyOpendCage()
    {
        foreach (var key in _keyList)
        {
            if(key.GetKeyType() == _Door.GetDoorKeyType())
            {
                RemoveKey(key);
                _Door.OpenCageDoor();
                doorOpened = true;
                break;//find alternative
            }
        }

        if (!doorOpened)
        {
            //AudioManager.instance.PlaySFX("WrongKey");
        }

        standNearDoor = true;
    }
}
