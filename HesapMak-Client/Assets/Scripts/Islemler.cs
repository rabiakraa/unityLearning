using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Islemler : MonoBehaviour
{

    public Text txt;
    public int islem;
    public int sayi1, sayi2;

    void Start()
    {

    }
    void Update()
    {

    }


    public void EkranaYazdir(Button button)
    {
        txt.text += button.GetComponentInChildren<Text>().text;

        if (Regex.Split(button.GetComponentInChildren<Text>().text, @"\D+") == null)
            switch (button.GetComponentInChildren<Text>().text)
            {
                case "+":
                    islem = 0;
                    break;
                case "-":
                    islem = 1;
                    break;
                case "*":
                    islem = 2;
                    break;
                case "÷":
                    islem = 3;
                    break;
                default:
                    break;
            }
    }

    public void Hesapla()
    {
        txt.text = "";
        string[] numbers = Regex.Split(txt.text, @"\D+");

        sayi1 = Convert.ToInt32(numbers[0]);
        sayi2 = Convert.ToInt32(numbers[1]);


        foreach (string value in numbers)
        {
            if (!string.IsNullOrEmpty(value))
            {
               int i = int.Parse(value);
               //Debug.Log(i);
            }
        }

        Debug.Log(sayi1 + islem + sayi2);
    }

}
