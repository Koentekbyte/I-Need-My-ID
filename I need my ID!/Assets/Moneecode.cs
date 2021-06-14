using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Moneecode : MonoBehaviour
{
    public InputField inputfield_ad;
    public InputField inputfield_am;
    public GameObject t_noadress,t_unvalid,t_balexceed,t_done;
    public Text txt;
    public int bal;

    
    
    public void debug()
    
    {   
        
        if (inputfield_ad.text != "notascammer98")      
        {        
                 t_done.active = false;
                 t_unvalid.active = false;
                 t_noadress.active = true;
                 
        }
     else if (float.Parse(inputfield_am.text) <= 0 )      
        {       t_done.active = false; 
                t_noadress.active = false;
                t_unvalid.active = true;
        }
        else
        {   
            
            PlayerPrefs.SetInt("balance",PlayerPrefs.GetInt("balance")-int.Parse(inputfield_am.text));
            bal = PlayerPrefs.GetInt("balance");
            t_done.active = false; 
            t_noadress.active = false;
            t_unvalid.active = false;
            t_done.active = true;
            
        }
    }   
    
    public void retry(){
        SceneManager.LoadScene("Monee");
    }
    

    void Start(){
        if(PlayerPrefs.GetInt("reset_monee")==1){
            PlayerPrefs.SetInt("balance",20000);
            bal = PlayerPrefs.GetInt("balance");
            PlayerPrefs.SetInt("money",0);

        }
        bal = PlayerPrefs.GetInt("balance");


       }
    
    void Update(){
        txt.text = PlayerPrefs.GetInt("balance").ToString();
        if(PlayerPrefs.GetInt("balance") < 20000){
            PlayerPrefs.SetInt("money",0);
        }
        else{
            PlayerPrefs.SetInt("money",1);
        }
        
    }
}


    
    
    

