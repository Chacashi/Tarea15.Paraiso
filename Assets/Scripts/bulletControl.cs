using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControll : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    public float directionY;
    public float speedY;
    public PlayerControll playerControll;
    private  int freezePoints;
    	
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0,speedY*directionY);
    }
    void OnTriggerEnter2D(Collider2D collider){
	if(collider.gameObject.tag== "Wall" ){
	Destroy(this.gameObject);
	}
        if(collider.gameObject.tag == "Enemy"){
	collider.gameObject.GetComponent<Animator>().SetTrigger("isDestroying");
	Destroy(this.gameObject);
	Destroy(collider.gameObject,1);
        playerControll.SetPoints(10);
	
	}
       
	}
    public void SetPlayerControll(PlayerControll playerControll){
	this.playerControll = playerControll;
	}
}

