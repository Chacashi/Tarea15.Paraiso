using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerBaseControll : MonoBehaviour
{

    public string loadToScene;
    public Text textPoints;
    public int points;
    
    void Start()
    {
     SetPoints(0);

    }	
    // Update is called once per frame
    void Update()
    {
	if(Input.GetKey(KeyCode.E) ==true){
	SceneManager.LoadScene(loadToScene);
	}
		
        
    }
    public void SetPoints(int pointsToAdd){
	points = points + pointsToAdd;
	textPoints.text = "Puntos: " + points;
	}
}
