using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Player pl;
    public Canvas go;

 
    private void Start()
    {
        
    }
    void Update()
    {
        if(pl._health == 0)
        {
            go.GetComponent<Canvas>().enabled = false;
        }    
    }
}
