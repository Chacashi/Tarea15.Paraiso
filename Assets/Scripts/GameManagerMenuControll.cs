using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerControll : MonoBehaviour
{
	public string sceneToLoad;
	
	public Button buttonPlay;
    
    void Start()
    {
	buttonPlay.onClick.AddListener(() => GoToScene());	

    }
  
    void GoToScene(){
	SceneManager.LoadScene(sceneToLoad);
	}
}
