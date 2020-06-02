using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destoryRedCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 30){
            YouWin();
        }
    }
    public int score;
    public Text scoreText;
    public Text winText;
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>().tag == "redCube"){  
            Destroy(other.gameObject);                
            AddScore();
        }   
        if(other.GetComponent<Collider>().tag == "blueCube"){  
            Destroy(other.gameObject);                
            minusScore();
        }         
    }

    void AddScore(){
        score++; 
        scoreText.text = score.ToString(); 
    }

    void minusScore(){
        score--;
        scoreText.text = score.ToString();
    }

    void YouWin(){
        winText.text = "RED WINS!!!!1!";
        Time.timeScale = 0f;
    }
}
