using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drayer : MonoBehaviour
{


    public float force=8f;
    
    Rigidbody temp;
    ArticulationBody Atemp;
    Vector3 plocal;
    float alength;
    

    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            

            Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 lll = ray2.direction;
            Vector3 dd = lll.normalized *alength;


            if (Physics.Raycast(ray2, out hit)&&!temp&&!Atemp)
            {

                Vector3 tvec = ray2.origin - hit.point;
                alength = tvec.magnitude;
               
                plocal = hit.transform.InverseTransformPoint(hit.point);

                temp = hit.rigidbody;
                Atemp = hit.articulationBody;
               

                
            }


            if (temp!=null)
            {
                
                
                Vector3 llaa = temp.transform.TransformPoint(plocal);

                Vector3 fdir = ray2.origin + dd - llaa;
                temp.AddForceAtPosition(fdir.normalized* 8f, llaa);
                
            }
            if (Atemp!=null)
            {
                Vector3 llaa = Atemp.transform.TransformPoint(plocal);

                Vector3 fdir = ray2.origin + dd - llaa;
                Atemp.AddForceAtPosition(fdir.normalized * force, llaa);
            }
        }
        else
        {
            temp = null;
            Atemp = null;
        }
        
        
    }
}
