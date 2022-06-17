using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public InputField inputField;
    public Text averageText;

    private List<float> marks = new List<float>();
    private int totalNumberOfMarks;

    void Update()
    {
        EnterMark();
        ReplaceComma0();     
    }

    void EnterMark()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && inputField.text != "")
        {
            totalNumberOfMarks += 1;
            marks.Add(float.Parse(inputField.text));
            inputField.text = "";
            float total = marks.Sum();
            float average = total / totalNumberOfMarks;
            averageText.text = average.ToString("F1");   
        }       
    }

    void ReplaceComma0()
    {
        if(averageText.text.Contains(",0"))
        {
            averageText.text = averageText.text.Replace(",0", "");
        }    
    }
}
