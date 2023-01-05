using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
	public float topBound = 30; 
	public float lowerBound = -10; 
	public GameObject uiGameOver;

    private void Awake()
    {
        uiGameOver = GameObject.Find("Gover").transform.Find("GameOver").gameObject; 
        
    }
    void Update()
    {
        if (transform.position.z > topBound) 
		{ Destroy(gameObject); }
		else if (transform.position.z < lowerBound) {

            gover();
		Destroy(gameObject); }
    }


    public void gover()
    {
        uiGameOver.SetActive(true);
        Debug.Log("GAME OVER!");
        Time.timeScale =0f;
    }
}
