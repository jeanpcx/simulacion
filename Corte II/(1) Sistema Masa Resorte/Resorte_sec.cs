using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resorte_sec : MonoBehaviour
{
    public float U;
    public float K;
    public float M;
    public Vector3 P;
    public Vector3 V;
    public Vector3 A;
    float PRprin;
    public GameObject Mass1;
    float tiempo = 0.1f;
    float distance = 10;
    

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
   
            Mass1 = GameObject.Find("Resorte1");
            Vector3 P1 = Mass1.GetComponent<Transform>().position;
            float K2 = Mass1.GetComponent<Resorte_1>().K;
        
            P = gameObject.GetComponent<Transform>().position;
            A = (-U * V - K * (P) + K2 * (P1 - transform.position)) / M;
            V = V + A * tiempo;
            P = P + V * tiempo;
            gameObject.GetComponent<Transform>().position = P;


    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 ObjPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = ObjPosition;
    }
}
