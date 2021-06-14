using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class end : MonoBehaviour
{
    public Text txt,money,socialmedia,malware,total;
    void Start()
    {
       if(PlayerPrefs.GetInt("money")==0){
           money.text = "You shouldn't have given any money to the scammer. every dollar fuels this fire!";
       }
       if(PlayerPrefs.GetInt("money")==1){
           money.text = "Good you followed SafeBoi's advice and did not give money to scammers";
       }
       if(PlayerPrefs.GetInt("sammy")==1 && PlayerPrefs.GetInt("sammy")==1 && PlayerPrefs.GetInt("sammy")==1 )
    }

    
    
}
