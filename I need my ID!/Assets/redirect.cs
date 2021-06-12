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
    public void re_safeboi()
    {
        SceneManager.LoadScene("Safeboi");
    }
    public void re_readme()
    {
        SceneManager.LoadScene("readme");
    }
}
