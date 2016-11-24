using UnityEngine;
using System.Collections;

public interface IEnemyAIState 
{
	void UpdateState();

	void OnTriggerEnter(Collider other);

	void ToFleeFromState();

	void ToIdleState ();

	void ToScaredState ();

	void OnTriggerExit (Collider other);
}
