using UnityEngine;
using System.Collections;

public class EnemyStatePattern : MonoBehaviour 
{
	
	public float searchingTurnSpeed = 120f;
	public float searchingDuration = 4f;
	public float sightRange = 20f;
	public Transform[] wayPoints;
	public MeshRenderer meshRendererFlag;
	public bool counting;

	[HideInInspector] public Transform fleeTarget;
	[HideInInspector] public IEnemyAIState currentState;
	[HideInInspector] public EnemyFleeFrom enemyFleeFrom;
	[HideInInspector] public EnemyIdle enemyIdle;
	[HideInInspector] public NavMeshAgent navMeshAgent;
	[HideInInspector] public EnemyScaredState enemyScaredState;

	private void Awake ()
	{
		enemyFleeFrom = new EnemyFleeFrom (this);
		enemyIdle = new EnemyIdle (this);
		enemyScaredState = new EnemyScaredState (this);

		navMeshAgent = GetComponent<NavMeshAgent> ();
	}

	void Start () 
	{
		currentState = enemyIdle;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentState.UpdateState();
	}
	private void OnTriggerEnter(Collider other)
	{
		currentState.OnTriggerEnter (other);
	}
	private void OnTriggerExit (Collider other)
	{
		currentState.OnTriggerExit (other);
	}
	private void OnTriggerStay (Collider other)
	{
		//counting = false;
	}
}