using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
public class Random : MonoBehaviour
{   
    public AudioSource robot;
    public GameObject text;
    private TMP_Text tmpText;
    private string[] h;
    private string[] b;

    private string[] m;

    private string[] g;


    private string gbhm = "";
    System.Random rand = new System.Random();
    void Awake() {
        
        TextAsset heongA = Resources.Load <TextAsset>("heong");
        TextAsset buA = Resources.Load <TextAsset>("bu");
        TextAsset gamA = Resources.Load <TextAsset>("gam");
        TextAsset meongA = Resources.Load <TextAsset>("meong");
        string heong = heongA.text;
        string bu = buA.text;
        string meong = meongA.text;
        string gam = gamA.text;  
        h = heong.Split(",");
        b = bu.Split(",");

        m = meong.Split(",");

        g = gam.Split(",");
  
    }
    
    // Start is called before the first frame update
    void Start()
    {
        gbhm = g[rand.Next(g.Length)] + b[rand.Next(b.Length)] + h[rand.Next(h.Length)]+ m[rand.Next(m.Length)];
        tmpText = text.GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    public void onClick()
    {        
        gbhm = g[rand.Next(g.Length)] + " " + b[rand.Next(b.Length)] + " " + h[rand.Next(h.Length)]+ " " +  m[rand.Next(m.Length)] + "입니다.";
        tmpText.text = gbhm;
        robot.Play();
    }
}
