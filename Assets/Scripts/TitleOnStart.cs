using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Same script functionality as DateOnStart but for title text
public class TitleOnStart : MonoBehaviour
{
    Text titleText;
    string title;

    // Start method assigns date and dateText value and make them equal to each other
    void Start()
    {
        title = GameObject.Find("ScrollContent").GetComponent<GenerateCouse>().courseTitle;
        titleText = this.gameObject.GetComponent<Text>();
        titleText.text = title;
    }
}
