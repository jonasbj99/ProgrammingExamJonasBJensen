using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Same script functionality as TitleOnStart but for date text
public class DateOnStart : MonoBehaviour
{
    Text dateText;
    string date;

    // Start method assigns a value to date and dateText and make them equal to each other
    void Start()
    {
        date = GameObject.Find("ScrollContent").GetComponent<GenerateCouse>().courseDate;
        dateText = this.gameObject.GetComponent<Text>();
        dateText.text = date;
    }
}
