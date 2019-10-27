using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnnig_of_Units : MonoBehaviour
{
    public GameObject ThisObjectsUnit;
    //public GameObject T1rangedUnit;
    //public GameObject T1wizardUnit;

    //public GameObject spawnLoc1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject TM1 = Instantiate(ThisObjectsUnit, this.gameObject.transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
