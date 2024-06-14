using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDownControll : MonoBehaviour
{
   void OnTriggerExit2D(Collider2D collider){
	if(collider.gameObject.tag=="Enemy"){
	Destroy(collider.gameObject);
	}
	}
}
