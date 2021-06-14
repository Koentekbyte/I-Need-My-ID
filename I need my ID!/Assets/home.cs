using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class home : MonoBehaviour
{
    public GameObject vm;
    public Text txt;
    public GameObject outline;
    public void voicemail()
    {
        vm.active = true;
        txt.text = "No DO NOT go to 'noscamlottery.com' the form will undoubtedly steal your personal info or give money to the address 'notascammer98'-lottery companies don't ask for 20,000 anyway! You'll get nothing!";
        outline.active = true;
        Invoke("close",22);
        
    }
    public void close(){
    SceneManager.LoadScene("Home");

}
}


