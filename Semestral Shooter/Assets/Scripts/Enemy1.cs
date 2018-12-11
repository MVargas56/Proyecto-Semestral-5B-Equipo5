using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : EnemyBase
{
    float valH;
    float valV;

    private void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        enemy = GetComponent<NavMeshAgent>();
        ps = GetComponent<PlayerStatus>();
    }

    void Update()
    {
        FollowPlayer();

        if (EnemyHealth <= 0)
        {
            Debug.Log("Enemy Destroyed");
            Destroy(gameObject);
        }
    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
        Debug.Log("Enemy Health = " + EnemyHealth);
    }

    void FollowPlayer()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerObj.transform.position);
        if (playerObj != null)
        {
            valH = 0;
            valV = 1;

            float currentRotation = transform.rotation.eulerAngles.y * Mathf.Deg2Rad;

            float moveZ = valV * velocity.z * Time.deltaTime;
            float moveX = valH * velocity.x * Time.deltaTime;

            Vector3 pos = transform.position;
            pos.z += moveZ * Mathf.Cos(currentRotation);
            pos.x += moveZ * Mathf.Sin(currentRotation);
            transform.position = pos;

            transform.Rotate(new Vector3(0, moveX, 0));

            transform.LookAt(playerObj.transform.position);
            //enemy.destination = playerObj.transform.position;
        }
        if (distanceToPlayer == 1)
        {
            valV = 0;
            StartCoroutine("DamageJugador");
        }
        else {
            valV = 1;
            StopAllCoroutines();
        }
    }

    IEnumerator DamageJugador () {
        yield return new WaitForSeconds(1f);
        ps.playerHealth -= DamagePlayer;
        Debug.Log("Player Health: " + ps.playerHealth);
    }
}
