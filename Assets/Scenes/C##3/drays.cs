using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drays : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    public GameObject aa,bb;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            
            Ray ray2 = camera.ScreenPointToRay(Input.mousePosition);
            //ray2 = camera.ScreenPointToRay(Input.mousePosition);

            Debug.DrawLine(ray.origin, ray.origin + ray.direction, Color.blue, 50);

            Vector3 kk = ray.origin + ray.direction;
            Debug.Log(kk.magnitude);



            Vector3 lll = ray2.direction;
            Vector3 dd = lll.normalized*Mathf.Sqrt(10000);
            

            Debug.DrawLine(ray2.origin, ray2.origin+dd, Color.green, 50);
            Debug.Log(dd.magnitude);
            Debug.Log(dd);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                hit.rigidbody.AddForceAtPosition(Vector3.up*20, hit.point);
                Debug.Log(hit.point);
                Debug.DrawLine(Vector3.zero, hit.point);

                GameObject aaa;
                aaa = new GameObject();
                aaa.transform.position = hit.point;
                Debug.DrawLine(camera.transform.position, hit.point, Color.red, 50);
                
            }
        }
        
    }
}
