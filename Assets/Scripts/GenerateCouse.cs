using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCouse : MonoBehaviour
{
    [SerializeField] GameObject parentObject;
    [SerializeField] GameObject coursePanel;
    public string courseTitle;
    public string courseDate;
    Vector2 downScale = new Vector2(1f, 1f);

    Transform parentTransform;
    RectTransform parentAdjust;
    float baseWidth = -100f;
    float startHeight = 1497.6f;
    float panelSize = 475f;
    float padding = 25f;

    // Method run on click of button, instantiating coursePanel prefab, giving the instantiated object a parent, and scaling the instantiated object.
    public void NewCourse()
    {
        GameObject newCoursePanel = Instantiate(coursePanel);
        newCoursePanel.transform.parent = parentObject.transform;
        newCoursePanel.transform.localScale = downScale;
    }

    void Update()
    {
        parentTransform = this.transform;
        parentAdjust = parentObject.GetComponent<RectTransform>();
        parentAdjust.sizeDelta = new Vector2(baseWidth, startHeight);

        if(parentTransform.childCount > 3)
        {
            parentAdjust.sizeDelta = new Vector2(baseWidth, padding+(panelSize * parentTransform.childCount));
        }
    }
}
