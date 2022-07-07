using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
   [SerializeField] private GameObject enemyPrefab;

   [SerializeField] private Transform[] spawnPoints;

	 [SerializeField] private Transform targetRef;

	 //public static Transform targetRefSingleton;

	 //private void Awake()
	 //{
		//	targetRefSingleton = GameObject.FindObjectOfType<PlayerMovementController>().gameObject.transform;
	 //}

	 private void Start()
	 {

			InvokeRepeating("SpawnEnemy", 10f, 2f);
	 }

	 private void SpawnEnemy()
	 {
			int randomPointIndex = Random.Range(0, spawnPoints.Length);



			GameObject enemyInstance = Instantiate
				 (
				 enemyPrefab,
				 spawnPoints[randomPointIndex].position,
				 spawnPoints[randomPointIndex].rotation
				 );

			enemyInstance.GetComponent<EnemyMovementController>().SetTarget(targetRef);
	 }
}
