using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public Text V_1;
    public Text V_2;

    public Text M_1;
    public Text M_2;

    public Text C_1;
    public Text C_2;

    GameObject O1;
    GameObject O2;
 
    public float MA1;
    public float MA2;
    public float CO1;
    public float CO2;
    public float VE1;
    public float VE2;
   
    // Update is called once per frame
    public void enviar()
    {
        VE1 = float.Parse(V_1.text);
        VE2 = float.Parse(V_2.text);
        MA1 = float.Parse(M_1.text);
        MA2 = float.Parse(M_2.text);
        CO1 = float.Parse(C_1.text);
        CO2 = float.Parse(C_2.text);
        O1 = GameObject.Find("Esfera -");
        O2 = GameObject.Find("Esfera +");
        O1.GetComponent<movimiento>().V.x = VE1;
        O2.GetComponent<mov_2>().V.x = VE2;
        
        O1.GetComponent<movimiento>().MA1 = MA1;
        O2.GetComponent<mov_2>().MA1 = MA1;


        O1.GetComponent<movimiento>().MA2 = MA2;
        O2.GetComponent<mov_2>().MA2 = MA2;

        O1.GetComponent<movimiento>().CO1 = CO1;
        O2.GetComponent<mov_2>().CO1 = CO1;

        O1.GetComponent<movimiento>().CO2 = CO2;
        O2.GetComponent<mov_2>().CO2 = CO2;
    }

   
}
