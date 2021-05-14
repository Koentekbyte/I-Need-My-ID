using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_leak : MonoBehaviour
{
    public GameObject block;
    public GameObject leak;
    
    public void pass(){
        block.active = true;
    }
}
