using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLAYERmovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    public LayerMask layer;
    public KeyCode left, right, up, down, reset;
    public Vector3 originalPos; 
    private Vector3 previousPos;

    public int score; 

 

    void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
        originalPos = gameObject.transform.position;  
    }

    void Update()
    { 
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,1,layer)){
            if(Vector3.Angle(transform.position-previousPos,hit.transform.up)>180){
                Destroy(hit.transform.gameObject);
            }
            
        }
        previousPos = transform.position;


        //z is always constant
        if(Input.GetKey(left)){
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if(Input.GetKey(right)){
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        else if(Input.GetKey(up)){
            rb.velocity = new Vector3(rb.velocity.x, moveSpeed, rb.velocity.z);
        }
        else if(Input.GetKey(down)){
            rb.velocity = new Vector3(rb.velocity.x, -moveSpeed, rb.velocity.z);
        }
        else{
            rb.velocity = new Vector3(0, 0, rb.velocity.z);
        }

        if(Input.GetKey(reset)){
            gameObject.transform.position = originalPos;
        }

    }

}
