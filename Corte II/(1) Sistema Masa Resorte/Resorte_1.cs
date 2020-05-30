using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Resorte_1: MonoBehaviour
{
    public float U;
    public float K;
    public float M;
    public Vector3 P;
    public Vector3 V;
    public Vector3 A;
    public GameObject Mass2;
    float tiempo = 0.1f;
    float distance = 10;
    Vector3 des;
    
    // Start is called before the first frame update
    void Start()
    {   
        des.x = 5;
    }

    // Update is called once per frame
    void Update()
    {
        P = gameObject.GetComponent<Transform>().position;
        A = (transform.position - U * V - K * (P + des)) / M;
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


