using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerData: MonoBehaviour  {

    public Text playerPoints;
    public InputField nameField;
    public Button startButton;

    private void Awake()
    {
        playerPoints.text ="Max points is" +" " + PlayerPrefs.GetInt("points").ToString()+" scored by "+ PlayerPrefs.GetString("topName");
    }

    private void FixedUpdate()
    {
        nameField.onEndEdit.AddListener(delegate { EditEnd(); });
    }

    void EditEnd()
    {
        PlayerPrefs.SetString("currentName", nameField.text);
        startButton.interactable = true;
    }
}
