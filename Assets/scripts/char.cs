using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class Charcook : MonoBehaviour
{
bool pressed = false;
public GameObject spriteObj;
private Image img;
public Sprite defaultOne;
private RectTransform rect;
public Sprite toChange;
    void Start () {
        pressed = false;
        img = spriteObj.GetComponent<Image>();
        rect = spriteObj.GetComponent<RectTransform>();
    }
    public void OnClick () {
        if (!pressed) {
        pressed = true;
        StartCoroutine(Shake());
        }
    }

    public void Update()
        {
            if (pressed)
                rect.anchoredPosition += new Vector2 (-2f, 0);
            else if (rect.anchoredPosition.x <= 0)
                rect.anchoredPosition += new Vector2 (5f,0);
        }
    IEnumerator Shake() {
        Debug.Log("ㅇㅇ");
        img.sprite = toChange;

        yield return new WaitForSeconds(0.1f);
        Debug.Log("야옹");
        img.sprite = defaultOne;
        pressed = false;
    }
}