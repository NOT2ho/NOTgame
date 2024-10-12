using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class FoodProd : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    System.Random rand = new System.Random();

    private Image img;
    private Image charImg;

    public Sprite nothing;

    public Sprite food0;

    public Sprite food1;

    public Sprite food2;

    public Sprite food3;

    public Sprite food4;

    public Sprite food5;

    public Sprite food6;

    public Sprite food7;

    public Sprite food8;

    public Sprite food9;

    public Sprite food10;

    public Sprite food11;
    private Sprite[] foods;

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
        
        List<Sprite> lst = new() { food0,food1,food2,food3,food4,food5,food6,food7,food8,food9,food10,food1};
        foods = lst.ToArray();
    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        img.sprite = foods[rand.Next(foods.Length)];
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
