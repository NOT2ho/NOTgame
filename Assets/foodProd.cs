using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class FoodProd : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Image img;
    private Image charImg;

    public Sprite nothing;
    public Sprite food;
    public GameObject foodObj;
    public GameObject char_;
    public Sprite char0;
    public Sprite char1;
    public Sprite char2;
    void Start() {
        img = foodObj.GetComponent<Image>();
        charImg = char_.GetComponent<Image>();
        charImg.sprite = char0;
        img.sprite = nothing;
    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        img.sprite = food;
        Debug.Log("drag on");
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        foodObj.transform.position = currentPos;
        charImg.sprite = char1;
   
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        img.sprite = nothing;
        charImg.sprite = char2;

        Debug.Log("drag off");
    }
}
