using UnityEngine;
using System.Collections;

public class EnemyScaredState : IEnemyAIState
{
	private Vector3 location;
	private readonly EnemyStatePattern enemy;
	private float clock;
	private bool counting;

	public EnemyScaredState (EnemyStatePattern enemyStatePattern)
	{
		enemy = enemyStatePattern;
		location = enemy.transform.position;
	}
	public void UpdateState()
	{
		Shaking ();
	}

	public void OnTriggerEnter(Collider other)
	{
		enemy.counting = !counting;
	}
	public void OnTriggerExit(Collider other)
	{
		if (!counting) 
		{
			clock = 5f;
			enemy.counting = true;
		}
	}

	public void ToFleeFromState()
	{
		enemy.currentState = enemy.enemyFleeFrom;
	}
	public void ToIdleState ()
	{
		enemy.currentState = enemy.enemyIdle;
	}
	public void ToScaredState ()
	{
		Debug.Log ("Not Applicable");
	}

	void Shaking ()
	{
		enemy.meshRendererFlag.material.color = Color.red;
		enemy.navMeshAgent.Stop ();
		//enemy.transform.position = enemy.transform.position + Vector3.up * 2f;

		if (clock > 0 && counting == true)
		{
			clock -= Time.deltaTime;
		}
		else if (clock <= 0 && counting == true)
		{
			counting = false;
			ToIdleState ();
		}
	}		
}
