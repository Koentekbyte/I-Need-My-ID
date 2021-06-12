using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inavigate : MonoBehaviour
{
    public GameObject Moni_scamsite;
    public InputField searchbar;
    public Text safeboi;
    
    public GameObject safeboi_inavigate,noscam_scamsite;
    public void browse()
    {   
        if(searchbar.text == "Moni.com"){
        noscam_scamsite.active = false;
        Moni_scamsite.active = true;
        safeboi_inavigate.active = true;
        safeboi.text = "SafeBoi: if a site is a misspelt version of a popular website's domain -IT'S A SCAM";
        
         }

         else if(searchbar.text == "noscamlottery.com"){ 
        noscam_scamsite.active = false;
        safeboi_inavigate.active = true;
        safeboi.text = "SafeBoi: I told you this is a clever money scam just report it already";
        
         }
    
    
    }



    
}
