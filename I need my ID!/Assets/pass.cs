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
            SceneManager.LoadScene("Home");  
        }
    }
}
 
 

