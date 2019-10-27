using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnnig_of_Units : MonoBehaviour
{
    public GameObject meleeUnits;
    public GameObject rangedUnits;
    public GameObject wizardUnits;
    public GameObject base1;
    public GameObject base2;
    public GameObject base3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            //GameObject spawnW = Instantiate(wizardUnits, base1.transform.position, Quaternion.identity);
            
           GameObject spawnM = Instantiate(meleeUnits, base1.transform.position, Quaternion.identity);
            spawnM.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 5f), ForceMode.Impulse);
            //GameObject spawnR = Instantiate(rangedUnits, base1.transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
