using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class catchat : MonoBehaviour
{   
  public GameObject unknown_msg;
  public GameObject mom_msg;
  public GameObject mom_pfp;
  public GameObject unknown_pfp;
  public GameObject safeboi_catchat,sammy_pfp,sammy_msg,block_outline,continue_outline;
  public Text text,block,kontinue;
  public int u,m,s,us,ms,ss,x;
  public GameObject banhammer;
  public Scene inav;
  private NewBehaviourScript scene1;
  void Start(){
    if(PlayerPrefs.GetInt("reset_catchat") == 1){ 
    PlayerPrefs.SetInt("ubc",0);
    PlayerPrefs.SetInt("mbc",0);
    PlayerPrefs.SetInt("sbc",0);
    PlayerPrefs.SetInt("mom",0);
    PlayerPrefs.SetInt("unknown",0);
    PlayerPrefs.SetInt("sammy",0);
    PlayerPrefs.SetInt("reset_catchat",0);
    
    
    }
    PlayerPrefs.SetInt("cc_click",1);
    
  }
  public void unknown(){
      PlayerPrefs.SetInt("scene",1);
      PlayerPrefs.SetInt("us",1);
      PlayerPrefs.SetInt("ms",0);
      PlayerPrefs.SetInt("ss",0);
       
      block_outline.active = true;
      continue_outline.active = true;

      sammy_pfp.active = false;
      sammy_msg.active = false;
      mom_pfp.active = false;
      mom_msg.active = false;
      unknown_msg.active = true;
      unknown_pfp.active = true;
      safeboi_catchat.active = true;
      text.text = "SafeBoi: The bad spelling is a tell-tale sign of an unprofessional scammer!";
      block.text = "block(unknown)";
      kontinue.text = "Oh dear! here are my details!";
      Debug.Log("unbanned");
      banhammer.active = false;
      
       if(PlayerPrefs.GetInt("ubc") == 1){
        block_outline.active = false;
        continue_outline.active = false;
        sammy_pfp.active = false;
        sammy_msg.active = false;
        mom_pfp.active = false;
        mom_msg.active = false;
        block.text = "";
        kontinue.text = "";
        block_outline.active = true;
        continue_outline.active = true;
        Debug.Log("banned");
        banhammer.active = true;
      }

      

  }
  public void mom(){
    PlayerPrefs.SetInt("scene",2);
    block_outline.active = true;
      continue_outline.active = true;
    sammy_pfp.active = false; 
    sammy_msg.active = false;
    unknown_msg.active = false;
    unknown_pfp.active = false;
    mom_msg.active = true;
    mom_pfp.active = true;
    safeboi_catchat.active = true;
    text.text = "SafeBoi: This person doesn't ask for personal info and is someone you know and trust";
    block.text = "block(mom)";
    kontinue.text = "Hi! there you go mum!";
    PlayerPrefs.SetInt("ms",1);
    PlayerPrefs.SetInt("us",0);
    PlayerPrefs.SetInt("ss",0);
    banhammer.active = false;
  
   if(PlayerPrefs.GetInt("mbc") == 1){
        block_outline.active = false;
        continue_outline.active = false;
        sammy_pfp.active = false;
        sammy_msg.active = false;
        mom_pfp.active = false;
        mom_msg.active = false;
        block.text = "";
        kontinue.text = "";
        block_outline.active = true;
        continue_outline.active = true;
        Debug.Log("banned");
        banhammer.active = true;
      }
  }

  public void sammy(){
    PlayerPrefs.SetInt("scene",3);
    block_outline.active = true;
      continue_outline.active = true;
    unknown_msg.active = false;
    unknown_pfp.active = false;
    mom_msg.active = false;
    mom_pfp.active = false;
    sammy_pfp.active = true;
    sammy_msg.active = true;


    safeboi_catchat.active = true;
    text.text = "SafeBoi: Don't enter this link. if something seems too good to be true then it probably is!";
    block.text = "block(sammy)";
    kontinue.text = "OK thanks I'll check it out!";
    PlayerPrefs.SetInt("ss",1);
    PlayerPrefs.SetInt("us",0);
    PlayerPrefs.SetInt("ms",0);
    banhammer.active = false;
    if(PlayerPrefs.GetInt("sbc") == 1){
        block_outline.active = false;
        continue_outline.active = false;
        sammy_pfp.active = false;
        sammy_msg.active = false;
        mom_pfp.active = false;
        mom_msg.active = false;
        block.text = "";
        kontinue.text = "";
        block_outline.active = true;
        continue_outline.active = true;
        Debug.Log("banned");
        banhammer.active = true;
      }
  }
    

    
  
  
  public void blokk(){
    if(PlayerPrefs.GetInt("us") == 1)
    {
      PlayerPrefs.SetInt("ubc",1);
      PlayerPrefs.SetInt("unknown",1);
      unknown();

    }
    
    else if(PlayerPrefs.GetInt("ms") == 1)
    {
      PlayerPrefs.SetInt("mbc",1);
      PlayerPrefs.SetInt("mom",0);
      mom();
    }
    else if(PlayerPrefs.GetInt("ss") == 1)
    {
      PlayerPrefs.SetInt("sbc",1);
      PlayerPrefs.SetInt("sammy",1);
      sammy();
    }
     }
  public void conntinue(){
    if(PlayerPrefs.GetInt("us") == 1)
    {
      PlayerPrefs.SetInt("unknown",0);
    }
    
    else if(PlayerPrefs.GetInt("ms") == 1)
    {
      PlayerPrefs.SetInt("mom",1);
      Debug.Log("hi");
    }
    else if(PlayerPrefs.GetInt("ss") == 1)
    {
      
      PlayerPrefs.SetInt("sammy",0);
      SceneManager.LoadScene("I-navigate");
      
    }
    
  }
   
    
  }

  
  
  
     
  

