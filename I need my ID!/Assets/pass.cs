using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pass : MonoBehaviour {
 
    public InputField inputfield;  
 
    public void CheckInput() {
        if (inputfield.text == "password123")      
        {
            Debug.Log("Password accepted");
            PlayerPrefs.SetInt("reset_monee",1);
            PlayerPrefs.SetInt("reset_inavigate",1);
            PlayerPrefs.SetInt("reset_catchat",1);     
            SceneManager.LoadScene("Home");  
        }
    }
}
 
 

