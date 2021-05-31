using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inavigate : MonoBehaviour
{
    public GameObject Moni_scamsite;
    public InputField searchbar;
    public Text safeboi;
    
    public GameObject safeboi_inavigate;
    public void browse()
    {   
        if(searchbar.text == "Moni.com"){ 
        Moni_scamsite.active = true;
        safeboi_inavigate.active = true;
        safeboi.text = "SafeBoi: if a site is a misspelt version of a popular website's domain -IT'S A SCAM";
        
    }}

    
}
