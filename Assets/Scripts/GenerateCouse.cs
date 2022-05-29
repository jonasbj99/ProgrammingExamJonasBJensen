using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCouse : MonoBehaviour
{
    [SerializeField] GameObject parentObject;
    [SerializeField] GameObject coursePanel;
    [SerializeField] string courseTitle;
    [SerializeField] string courseDate;
    Text titleText;
    Text dateText;
    string titleName = "TitleText";
    string dateName = "DateText";
    Vector2 downScale = new Vector2(1f, 1f);

    public void NewCourse()
    {
        GameObject newCoursePanel = Instantiate(coursePanel);
        newCoursePanel.transform.parent = parentObject.transform;
        newCoursePanel.transform.localScale = downScale;
        FindText(titleText, titleName, courseTitle);
        FindText(dateText, dateName, courseDate);
    }

    void FindText( Text courseText, string textName, string courseString)
    {
        courseText = GameObject.Find(textName).GetComponent<Text>();
        courseText.text = courseString;
    }
}
