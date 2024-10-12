using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBG : MonoBehaviour
{
    public GameObject spriteObj;
    private Image img;
    public Sprite toChange;

    void Start()
    {
        img = spriteObj.GetComponent<Image>();

    }

    public void OnClick () {
        img.sprite = toChange;
    }

}
