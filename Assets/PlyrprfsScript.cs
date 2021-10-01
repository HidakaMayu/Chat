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
            string ho = System.DateTime.Now.Hour.ToString();
            string mn = System.DateTime.Now.Minute.ToString();
            string sc = System.DateTime.Now.Second.ToString();

            displayText.text = inputField.text + "(" + ho + ":" + mn + ":" + sc + ")" + "\n" + displayText.text;
            PlayerPrefs.SetString("ChatLog", displayText.text);
            PlayerPrefs.Save();
            inputField.text = "";
        }
    }
}
