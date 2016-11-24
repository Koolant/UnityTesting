using UnityEngine;
using System.Collections;

public class NavMoveTo : MonoBehaviour {

	public Transform player;
	GameObject enemy;
    NavMeshAgent agent;
    
	void Awake ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		agent.SetDestination(player.position);
		Debug.Log (player.position);
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}


/*transform.rotation = Quaternion.LookRotation(transform.position - player.position);
 
 Vector3 runTo = transform.position + transform.forward * multiplyBy;

NavMeshHit hit;
NavMesh.SamplePosition(runTo, out hit, 5, 1 << NavMesh.GetNavMeshLayerFromName("Default"));
 
 myNMagent.SetDestination(hit.position);
 */