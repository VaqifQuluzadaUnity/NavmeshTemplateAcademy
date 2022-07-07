using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementController : MonoBehaviour
{
   [SerializeField] private NavMeshAgent playerAgent;

   [SerializeField] private Camera playerCam;

	 [SerializeField] private LayerMask availableZones;

	 private void Update()
	 {
			if (Input.GetMouseButtonDown(0))
			{
				 Ray cameraMouseRay = playerCam.ScreenPointToRay(Input.mousePosition);

				 if (Physics.Raycast(cameraMouseRay,out RaycastHit hit,2000,availableZones))
				 {
						playerAgent.SetDestination(hit.point);
				 }
			}
	 }
}
