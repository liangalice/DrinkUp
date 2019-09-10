using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Todays_Date : MonoBehaviour
{
 
    [SerializeField] Text countdownText;

    string timeAndDate = System.DateTime.Now.ToString("MM/dd/y");
    // Start is called before the first frame update
    void Start()
    {
        
        countdownText.text = "Today's date: "+ timeAndDate;

    }
    void Update()
    {
        //   countdownText = timeAndDate;
    }
}