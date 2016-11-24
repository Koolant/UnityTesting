using UnityEngine;
using System.Collections;

public class EnemyIdle : IEnemyAIState {

	private int nextWayPoint;
	private readonly EnemyStatePattern enemy;

	public EnemyIdle (EnemyStatePattern enemyStatePattern)
	{
		enemy = enemyStatePattern;
	}

	public void UpdateState()
	{
		Idling ();
	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			ToScaredState ();
		}
	}
	public void OnTriggerExit (Collider other)
	{
		
	}
	public void ToFleeFromState()
	{
		enemy.currentState = enemy.enemyFleeFrom;
	}
	public void ToIdleState()
	{
		Debug.Log ("Not Applicable");
	}
	public void ToScaredState()
	{
		enemy.currentState = enemy.enemyScaredState;
	}
	void Idling ()
	{
		enemy.meshRendererFlag.material.color = Color.green;
		enemy.navMeshAgent.destination = enemy.wayPoints [nextWayPoint].position;
		enemy.navMeshAgent.Resume ();

		if (enemy.navMeshAgent.remainingDistance <= enemy.navMeshAgent.stoppingDistance && !enemy.navMeshAgent.pathPending)
		{
			nextWayPoint = (nextWayPoint + 1) % enemy.wayPoints.Length;
		}
	}
}
