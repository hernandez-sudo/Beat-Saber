using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{    
    public GameObject[] cubes; //for this we will need our CUBE PREFABS so we put them in an array
    public Transform[] points; //this array will hold the coordinate points on where to spawn
    //this is for the beat of the song to "match" the cube
    public float beat = (60/130) *2;  //beats per minute
    private float timer;

    void Start(){
        
    }
 
    // Update is called once per frame 
    void Update(){
        if(timer>beat){
            //to randomize which colored cube comes out either red or blue
            GameObject cube = Instantiate(cubes[Random.Range(0,2)], points[Random.Range(0,4)]);
            //for cube to not move and only in a single file
            cube.transform.localPosition = Vector3.zero;
            //to rotate cube up, down, left, or right
            //cube.transform.Rotate(transform.forward, 90* Random.Range(0,4)); 
            //updating the timer
            timer -= beat;
        }
        //have to update to deltaTime for better runtime
        timer += Time.deltaTime;
    }
}
