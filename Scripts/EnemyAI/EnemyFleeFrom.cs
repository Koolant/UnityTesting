using UnityEngine;
using System.Collections;

public class EnemyFleeFrom : IEnemyAIState {

	private readonly EnemyStatePattern enemy;
	private int nextWayPoint;
	public EnemyFleeFrom (EnemyStatePattern enemyStatePattern)
	{
		enemy = enemyStatePattern;
	}

	public void UpdateState()
	{

	}
	public void OnTriggerEnter(Collider other)
	{

	}
	public void OnTriggerExit (Collider other)
	{
		
	}
	public void ToFleeFromState()
	{

	}
	public void ToIdleState()
	{

	}
	public void ToScaredState()
	{
		
	}
}