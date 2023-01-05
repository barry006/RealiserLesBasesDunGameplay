using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject[] animalPrefabs;
[SerializeField]private float spawnRangeX = 5;
[SerializeField]private float spawnPosZ = 13;
public float startDelay = 2;
[SerializeField] private float spawnInterval = 1.5f;



void Start() { InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  }


void Update() {
			 
			  }


void SpawnRandomAnimal() {
	
int animalIndex = Random.Range(0, animalPrefabs.Length);
	
Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);	

Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
	

}	
			 
}

//------------------------------------
//public class ExampleScript : MonoBehaviour
//{
 //public Rigidbody projectile;

   // void Start()
    //{
     //   InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);
//    }

  //  void LaunchProjectile()
    //{
      //  Rigidbody instance = Instantiate(projectile);

        //instance.velocity = Random.insideUnitSphere * 5;
    //}
//}

