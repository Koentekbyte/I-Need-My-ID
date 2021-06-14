using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{   public Text txt;
    // Start is called before the first frame update
    void Awake()
    {
      DontDestroyOnLoad(this);  
    }

    // Update is called once per frame
    public void sammycall()
    {   
        txt.text = "Moni.com";
    }
}
