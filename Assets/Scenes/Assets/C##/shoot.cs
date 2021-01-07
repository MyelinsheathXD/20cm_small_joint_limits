using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceA=4000;



    public GameObject shpererigid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullit = Instantiate(shpererigid, transform.position, transform.rotation);
            bullit.GetComponent<Rigidbody>().AddForce(transform.forward * forceA);
        }

    } 
}
