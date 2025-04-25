using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_KeyHolder : MonoBehaviour
{
    [SerializeField] private KeyHolder _keyHolder;
    [SerializeField] private RectTransform _KeySlotContainer;
    [SerializeField] private RectTransform _KeySlotTemplate;


    // Start is called before the first frame update
    void Start()
    {
        _keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
    }

    private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
    {
        //Debug.Log("Event called");

        UpdateUI();
    }

    private void UpdateUI()
    {
        foreach(Transform slot in _KeySlotContainer)
        {
            if (slot == _KeySlotTemplate) continue;
            Destroy(slot.gameObject);
        }
        //Debug.Log("Added in UI");
        int x = 0, y = 0;
        float cellSize = 74f;
        foreach (Key _key in _keyHolder.GetKeyList())
        {
            RectTransform keySlotRectTransform = Instantiate(_KeySlotTemplate, _KeySlotContainer).GetComponent<RectTransform>();
            keySlotRectTransform.gameObject.SetActive(true);
            keySlotRectTransform.anchoredPosition = new Vector2(x * cellSize, y * cellSize);
            x++;

            Image _image = keySlotRectTransform.Find("KeyImage").GetComponent<Image>();
            _image.sprite = _key.GetSprite();
        }
    }

}
