using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class REDCubeMovement : MonoBehaviour
{ 
    
    void Update()
    {
        //THIS ONE LINE OF CODE IS WHAT MOVES THE CUBE FORWARDS
        //BY USING THE TRANSFORM PROPERTY
        transform.position += Time.deltaTime * transform.forward * 2; 
    
    }


}