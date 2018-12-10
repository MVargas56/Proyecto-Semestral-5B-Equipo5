using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour
{
    protected GameObject playerObj;
    protected NavMeshAgent enemy;
    protected Rigidbody erb;
    protected int EnemyHealth = 10;
    public Vector3 velocity;
    
    void Start ()
    {

    }
	
	void Update () {
		
	}
}
