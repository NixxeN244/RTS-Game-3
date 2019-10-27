using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MELEEUNIT : MonoBehaviour
{
    public GameObject theEnemy;  //the enemy of this specific unit
    NavMeshAgent agent;
    System.Random rnd = new System.Random();

    private float health=10f;
    private float speed=5f;
    private float attackDam=3f;
    private int a = 1;
    

    // Start is called before the first frame update
    void Start()
    {
       int a =  rnd.Next(1, 3);
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
       
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(theEnemy.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ranged Unit Team 1" || collision.gameObject.tag == "Ranged Unit Team 2" || collision.gameObject.tag == "Ranged Unit Team 3"  )
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
