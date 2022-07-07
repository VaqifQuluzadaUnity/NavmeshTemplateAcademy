using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementController : MonoBehaviour
{
   [SerializeField] private NavMeshAgent enemyAgent;

   private Transform target;

	 private void Start()
	 {
			InvokeRepeating("FollowTarget", 0, 0.05f);
			
	 }

	 public void SetTarget(Transform targetObject)
	 {
      target = targetObject;
	 }

	 private void FollowTarget()
	 {
			if (target)
			{
				 enemyAgent.SetDestination(target.position);
			}
	 }
}
