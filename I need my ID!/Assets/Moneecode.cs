using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneecode : MonoBehaviour
{
    public InputField inputfield_ad;
    public InputField inputfield_am;
    public GameObject t_noadress,t_unvalid,t_balexceed,t_done;
    
    public void debug()
    {
        if (inputfield_ad.text != "notascamma98")      
        {
                 t_noadress.active = true;
        }
        else if (int.Parse(inputfield_am.text) <= 0 )      
        {
                 t_unvalid.active = true;
        }
        if (inputfield_ad.text != "notascamma98")      
        {
                 t_noadress.active = true;
        }
    }

    
    
    
}
