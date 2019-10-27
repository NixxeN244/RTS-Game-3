using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WIZARDUNIT : MonoBehaviour
{
    GameObject theEnemy;
    GameObject theEnemy2;//the enemy of this specific unit
    NavMeshAgent agent;
    System.Random rnd = new System.Random();

    private float health = 20f;
    private float speed = 5f;
    private float attackDam = 10f;
    private int a = 1;
    // Start is called before the first frame update
    void Start()
    {


        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        int a = rnd.Next(1, 3);
        switch (a)
        {
            case 1:
                theEnemy = GameObject.FindGameObjectWithTag("Ranged Unit Team 1");
                break;
            case 2:
                theEnemy = GameObject.FindGameObjectWithTag("Ranged Unit Team 2");
                break;
            case 3:
                theEnemy = GameObject.FindGameObjectWithTag("Ranged Unit Team 3 ");
                break;
        }
        int b = rnd.Next(1, 3);
        switch (b)
        {
            case 1:
                theEnemy2 = GameObject.FindGameObjectWithTag("Melee Unit Team 1");
                break;
            case 2:
                theEnemy2 = GameObject.FindGameObjectWithTag("Melee Unit Team 2");
                break;
            case 3:
                theEnemy2 = GameObject.FindGameObjectWithTag("Melee Unit Team 3 ");
                break;
        }
        agent.SetDestination(theEnemy.transform.position);
        agent.SetDestination(theEnemy2.transform.position);

        float distance = 5f;
        if (Vector3.Distance(theEnemy.transform.position, this.gameObject.transform.position) < distance)
        {
            Destroy(theEnemy.gameObject);
            Destroy(this.gameObject);
        }


        if (Vector3.Distance(theEnemy2.transform.position, this.gameObject.transform.position) < distance)
        {
            Destroy(theEnemy2.gameObject);
            Destroy(this.gameObject);
        }
    }
}
