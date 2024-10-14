using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using Unity.VisualScripting;

public class CharButton : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
public AudioSource sound0;
public AudioSource sound1;

int count;
float xPos;
bool pressed = false;
public GameObject hand;
public Sprite toChange1;
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
        sound0.Play();
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
        void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        hand.SetActive(true);

        xPos = eventData.position.x; 
         sound1.Play();

    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        hand.transform.position = currentPos; 
        if (Math.Abs(xPos - currentPos.x)<0.1)
        img.sprite = toChange1;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        hand.SetActive(false);
        img.sprite = defaultOne;

    }
}
