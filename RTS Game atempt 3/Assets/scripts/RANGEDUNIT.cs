using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RANGEDUNIT : MonoBehaviour
{
    public GameObject theEnemy;
    NavMeshAgent agent;
    System.Random rnd = new System.Random();

    private float health=10f;
    private float speed=7f;
    private float attackDam=3f;
    private int a;

  
    // Start is called before the first frame update
    void Start()
    {
        int a = rnd.Next(1, 3);
        switch (a)
        {
            case 1:
                theEnemy = GameObject.FindGameObjectWithTag("Base 1");
                break;
            case 2:
                theEnemy = GameObject.FindGameObjectWithTag("Base 2");
                break;
            case 3:
                theEnemy = GameObject.FindGameObjectWithTag("Base 3");
                break;
        }

        agent = GetComponent<NavMeshAgent>();

    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(theEnemy.transform.position);
        float distance = 2f;
        if (Vector3.Distance(theEnemy.transform.position, this.gameObject.transform.position) < distance)
        {
            Destroy(theEnemy);
            Destroy(this.gameObject);
        }
        else
        {

        }

    }
}
