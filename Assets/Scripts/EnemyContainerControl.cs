using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
	private float currentTime = 0;
	public float generatorTime;
	public GameObject enemyPrefab;
	public float minPositionX;
	public float maxPositionX;
	public float yPosition;
        float xPosition;
	

    // Update is called once per frame
    void Update()
    { 
        xPosition= Random.Range(minPositionX, maxPositionX);
	currentTime= currentTime+ Time.deltaTime;
	if(generatorTime<= currentTime){
	Instantiate(enemyPrefab, new Vector2(xPosition, yPosition), transform.rotation);
       
	currentTime = 0;
         
	}
        
    }
 
 
 
}
