using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlyrprfsScript : MonoBehaviour
{
    

    string str;

    [SerializeField] InputField inputField;
    [SerializeField]Text displayText;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("ChatLog"))
        {
            PlayerPrefs.SetString("ChatLog", null);
        }
        string startLog = PlayerPrefs.GetString("ChatLog");
        displayText.text = startLog.ToString();
    }

    public void SendText()
    {
        if(inputField != null)
        {
            string da = System.DateTime.Now.ToString("MM/dd/yyyy H:mm:ss");

            displayText.text = inputField.text + "(" + da + ")" + "\n" + displayText.text;
            PlayerPrefs.SetString("ChatLog", displayText.text);
            PlayerPrefs.Save();
            inputField.text = "";
        }
    }
}
