using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
    public Text web,money,socialmedia,malwaretxt,total;
    void Start()
    {
       if(PlayerPrefs.GetInt("money")==0){
           money.text = "You shouldn't have given any money to the scammer. every dollar fuels this fire!";
           PlayerPrefs.SetInt("money_final",1);
       }
       if(PlayerPrefs.GetInt("money")==1){
           money.text = "Good you followed SafeBoi's advice and did not give money to scammers";
       }
       if(PlayerPrefs.GetInt("sammy")==1 && PlayerPrefs.GetInt("unknown")==1 && PlayerPrefs.GetInt("mom")==1 && PlayerPrefs.GetInt("cc_click") == 1)
       {
           socialmedia.text = "Great job! You managed to block the scammer, give a recipe to mom and block sammy. You can tell spam messages from genuine ones!";
           PlayerPrefs.SetInt("socialmedia_final",2);
       }
        if(PlayerPrefs.GetInt("sammy") == 0 && PlayerPrefs.GetInt("unknown") == 0 || PlayerPrefs.GetInt("mom") == 0 && PlayerPrefs.GetInt("unknown") == 0 || PlayerPrefs.GetInt("mom") == 0 && PlayerPrefs.GetInt("sammy") == 0)
        {
           socialmedia.text = "mmhh you got something wrong. Make sure to read messages carefully so you don't block trusted ones and communicate with malicious ones. You also could've ignored some messages";
           PlayerPrefs.SetInt("socialmedia_final",1);
       }
        if(PlayerPrefs.GetInt("sammy") == 0  || PlayerPrefs.GetInt("unknown") == 0 || PlayerPrefs.GetInt("mom") == 0)
    {
           socialmedia.text = "mmhh you got things wrong. Make sure to read messages carefully so you don't block trusted ones and communicate with malicious ones. You also could've ignored some messages";
           PlayerPrefs.SetInt("socialmedia_final",1);
       }
       if(PlayerPrefs.GetInt("sammy") == 0 && PlayerPrefs.GetInt("unknown") == 0 && PlayerPrefs.GetInt("mom") == 0){
           socialmedia.text = "Wow you got every single thing wrong. You need to pay attention to SafeBoi giving you advice on how to identity threats. you also might've missed out on all the questions";
           PlayerPrefs.SetInt("socialmedia_final",0);
       }
       if(PlayerPrefs.GetInt("malware") == 1){
           malwaretxt.text = "Yes. YOUR PC GOT INFECTED BY THE ID THEFT MALWARE. YOUR PC WILL BE DESTROYED!!";
           PlayerPrefs.SetInt("doom_malware",1);
       }
       if(PlayerPrefs.GetInt("malware") != 1){
           malwaretxt.text = "No";
           PlayerPrefs.SetInt("doom_malware",0);
       }
       if(PlayerPrefs.GetInt("idstolen")!=1){
           web.text = "You stayed safe online! good job you did not enter personal info on shady links";
           PlayerPrefs.SetInt("doom_ids",0);

       }
       if(PlayerPrefs.GetInt("idstolen")==1){
           web.text = "WE CANNOT TRUST YOU ANYMORE SINCE YOU MIGHT BE ANOTHER PERSON. YOU ENTERED CONFIDENTIAL IN AN UNSAFE WEBSITE!";
           PlayerPrefs.SetInt("doom_ids",1);
       }
       if(PlayerPrefs.GetInt("money_final")+PlayerPrefs.GetInt("socialmedia_final",1)==3 ||PlayerPrefs.GetInt("money_final")+PlayerPrefs.GetInt("socialmedia_final",1)==2 && PlayerPrefs.GetInt("doom_malware")+PlayerPrefs.GetInt("doom_ids")==0){
          total.text = "We're happy to announce you will be offered a job at CWC! You are a careful and smart person who can tell threat from safety!";
       }
       if(PlayerPrefs.GetInt("money_final")+PlayerPrefs.GetInt("socialmedia_final",1) <= 1 && PlayerPrefs.GetInt("doom_malware")+PlayerPrefs.GetInt("doom_ids")!=0 || PlayerPrefs.GetInt("money_final")+PlayerPrefs.GetInt("socialmedia_final",1) <= 1 || PlayerPrefs.GetInt("doom_malware")+PlayerPrefs.GetInt("doom_ids")!=0){
          total.text = "We regret to inform you that your PC will be destructed to prevent it becoming a bot transferring malware. This is due to ignoring the advice of SafeBoi and/or being untrustworthy due to your identity being stolen and/or you downloaded the very malware we are trying to overcome.";
       }
       
    }  
    public void reset(){
        
        PlayerPrefs.SetInt("reset_monee",1);
        PlayerPrefs.SetInt("reset_inavigate",1);
        PlayerPrefs.SetInt("reset_catchat",1);
        PlayerPrefs.SetInt("cc_click",0);
        SceneManager.LoadScene("Lockscreen");
        


    }
    
    
}
