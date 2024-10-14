using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class FoodProd : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    System.Random rand = new System.Random();
    public AudioSource coin;
    private Sprite randFood ;
    
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
    public Sprite char3;
    public Sprite char4;
    public Sprite char5;
    public Sprite char6;
    
    bool pressed = false;
    public GameObject spriteObj;
    private RectTransform rect;
    void Start() {
        pressed = false;
        rect = char_.GetComponent<RectTransform>();

        img = foodObj.GetComponent<Image>();
        charImg = char_.GetComponent<Image>();
        charImg.sprite = char0;
        img.sprite = nothing;
        
        List<Sprite> lst = new() { food0,food1,food2,food3,food4,food5,food6,food7,food8,food9,food10,food1};
        foods = lst.ToArray();
    }
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        foodObj.SetActive(true);
        randFood = foods[rand.Next(foods.Length)];
        img.sprite = randFood;
        
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position; 
        foodObj.transform.position = currentPos;
        charImg.sprite = char6;

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        //img.sprite = nothing;
        foodObj.SetActive(false);
        if (randFood == food1 || randFood == food2) 
            charImg.sprite = char2;
        else if (randFood == food5 || randFood == food6 || randFood == food7 || randFood == food10) 
            charImg.sprite = char3;
        else if (randFood == food0 || randFood == food3 || randFood == food8) 
            charImg.sprite = char4;
        else  
            charImg.sprite = char5;
        char_.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        coin.Play();
    }
}
