using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeys : MonoBehaviour
{
    [SerializeField] private KeyHolder _FreedomKeyHolder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(GameConst.keyTag))
        {
            Debug.Log("Key found");
            Key _key = collision.GetComponent<Key>();
            _FreedomKeyHolder.AddKey(_key);
            Destroy(_key.gameObject);
        }
    }
}
