using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Torque : MonoBehaviour
{
    Quaternion quaternion;
    GameObject extremo;
    public float radio, masa, mInercia, tiempo;
    Vector3 pAngular, fTorque, aAngular, vAngular;

    public Text acex, acey, velx,vely,tx,ty;

    void Start()
    {
        vAngular.x = 0;
        vAngular.y = 0;
        vAngular.z = 0;
        tiempo = 0.01f;
        masa =1f;
        extremo = GameObject.Find("pExtremo");
        Vector3 tmp = extremo.GetComponent<Transform>().position;
        radio = tmp.x;
    }


    void Update()
    {
        pAngular = gameObject.GetComponent<Transform>().rotation.eulerAngles;
        fTorque = extremo.GetComponent<Fuerza>().fAplicada * radio;
        mInercia = (masa * Mathf.Pow(radio, 2)) / 3;

        aAngular = fTorque / mInercia;
        vAngular = vAngular + aAngular * tiempo;

        pAngular = pAngular + vAngular * tiempo;
        quaternion = Quaternion.Euler(pAngular.x, pAngular.y, pAngular.z);

        //transform.rotation = quaternion;
        gameObject.GetComponent<Transform>().rotation = quaternion;

        acey.text = aAngular.y.ToString();
        vely.text = vAngular.y.ToString();
        ty.text = fTorque.y.ToString();
    }
}
