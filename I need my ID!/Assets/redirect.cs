using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class redirect : MonoBehaviour
{
    
    public void re_catchat()
    {
        SceneManager.LoadScene("Catchat");
    }
    public void re_monee()
    {
        SceneManager.LoadScene("Monee");
    }
    public void re_home()
    {
        SceneManager.LoadScene("Home");
   }
    
    public void re_inavigate()
    {
        SceneManager.LoadScene("I-navigate");
    }
}
