using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepControll : MonoBehaviour
{
	Rigidbody2D _compRigidbody2D;
	Animator _compAnimator;
	public float speedY;
        public GameManagerBaseControll gameManagerBase;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
	_compAnimator = GetComponent<Animator>();
    }


    
     void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0,-speedY);
    }
    

}
