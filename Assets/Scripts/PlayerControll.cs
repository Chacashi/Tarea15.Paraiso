using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    public AudioSource _compAudioSource;
    public float horizontal;
    public float vertical;
    public float speedX;
    public float speedY;
    public GameObject bulletPrefab;
    public GameManagerBaseControll gameManagerBase;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");
       vertical = Input.GetAxisRaw("Vertical"); 
	if(Input.GetButtonDown("Fire1") ==  true){
	GameObject bullet = Instantiate( bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<bulletControll>().SetPlayerControll(this);
        
	_compAudioSource.Play();
	}
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(horizontal*speedX, vertical*speedY);
    }
    void OnTriggerEnter2D(Collider2D collider){
	if (collider.gameObject.tag == "Enemy"){
	collider.gameObject.GetComponent<Animator>().SetTrigger("isDestroying");
	Destroy(collider.gameObject,1);
	} 
	}
      public void SetPoints(int pointsToAdd){
	gameManagerBase.SetPoints(pointsToAdd);
	}	
}
