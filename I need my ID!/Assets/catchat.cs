using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
  void start(){
    PlayerPrefs.SetInt("ubc",u);
    PlayerPrefs.SetInt("mbc",m);
    PlayerPrefs.SetInt("sbc",s);
    PlayerPrefs.SetInt("us",us);
    PlayerPrefs.SetInt("ms",ms);
    PlayerPrefs.SetInt("ss",ss);
    PlayerPrefs.SetInt("scene",x);
    
    
  }
  public void unknown(){
      PlayerPrefs.SetInt("scene",1);
      PlayerPrefs.SetInt("us",1);
      PlayerPrefs.SetInt("ms",0);
      PlayerPrefs.SetInt("ss",0);
      if(PlayerPrefs.GetInt("ubc") == 0){  
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
      }
      else if(PlayerPrefs.GetInt("ubc") == 1){
        block_outline.active = false;
        continue_outline.active = false;
        sammy_pfp.active = false;
        sammy_msg.active = false;
        mom_pfp.active = false;
        mom_msg.active = false;
        block.text = "block(unknown)";
        kontinue.text = "Oh dear! here are my details!";
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
    text.text = "SafeBoi: Don't enter this link. if something seems too good to be true then it pobably is!";
    block.text = "block(sammy)";
    kontinue.text = "OK thanks I'll check it out!";
    PlayerPrefs.SetInt("ss",1);
    PlayerPrefs.SetInt("us",0);
    PlayerPrefs.SetInt("ms",0);
  
  }
  public void blokk(){
    if(PlayerPrefs.GetInt("us") == 1)
    {
      PlayerPrefs.SetInt("ubc",0);

    }
    
    else if(PlayerPrefs.GetInt("ms") == 1)
    {
      PlayerPrefs.SetInt("mbc",1);
    }
    else if(PlayerPrefs.GetInt("ss") == 1)
    {
      PlayerPrefs.SetInt("sbc",1);
    }
     }
  public void conntinue(){
    if(PlayerPrefs.GetInt("us") == 1)
    {
      PlayerPrefs.SetInt("ubc",2);
    }
    
    else if(PlayerPrefs.GetInt("ms") == 1)
    {
      PlayerPrefs.SetInt("mbc",2);
    }
    else if(PlayerPrefs.GetInt("ss") == 1)
    {
      PlayerPrefs.SetInt("sbc",2);
    }
  
  }
  
  
  }   
  

