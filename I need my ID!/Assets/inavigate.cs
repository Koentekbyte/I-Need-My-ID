using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inavigate : MonoBehaviour
{
    public GameObject Moni_scamsite;
    public InputField searchbar;
    public Text safeboi;
    public InputField an,ap;
    public int mw,ids;
    
    public GameObject safeboi_inavigate,noscam_scamsite,CWC,safeboicom;
    public void browse()
    {   
        if(searchbar.text == "Moni.com"){
        noscam_scamsite.active = false;
        safeboicom.active = false;
        CWC.active = false; 
        Moni_scamsite.active = true;
        safeboi_inavigate.active = true;
        safeboi.text = "SafeBoi: if a site is a misspelt version of a popular website's domain -IT'S A SCAM";
        
         }


         else if(searchbar.text == "noscamlottery.com"){
             Moni_scamsite.active = false;
             safeboicom.active = false;
             CWC.active = false; 
             noscam_scamsite.active = true;
             safeboi_inavigate.active = true;
             safeboi.text = "PassWord: name = johnjohnson123 pass = anime123/Safeboi: Don't enter info on shady sites";
         }
        else if(searchbar.text == "safeboi.com"){
             Moni_scamsite.active = false;
             CWC.active = false; 
             noscam_scamsite.active = false;
             safeboicom.active = true;
             safeboi_inavigate.active = false;
             safeboi.text = "";
        
         }
         else if(searchbar.text == "CWC.org"){
             CWCdotorg();
        
         }
        
    
    }
     public void noscamleak()
    {
        if(an.text == "johnjohnson123" && ap.text =="anime123")
        {
           PlayerPrefs.SetInt("idstolen",1);
           ids = PlayerPrefs.GetInt("idstolen");
           
        }
     
        
        
    }
    public void CWCdotorg(){
      CWC.active = true;
    }
    public void finish(){
        SceneManager.LoadScene("end");
        
    }

    public void malware(){
        PlayerPrefs.SetInt("malware",1);
        mw = PlayerPrefs.GetInt("malware");
    }

    void Start(){
        if(PlayerPrefs.GetInt("reset_inavigate")==1){
            PlayerPrefs.SetInt("malware",0);
            mw = PlayerPrefs.GetInt("malware");
            PlayerPrefs.SetInt("idstolen",0);
            ids = PlayerPrefs.GetInt("idstolen");
            PlayerPrefs.SetInt("reset_inavigate",0);
        }
        PlayerPrefs.SetInt("malware",mw);
        PlayerPrefs.SetInt("idstolen",ids);
        
    }
}
