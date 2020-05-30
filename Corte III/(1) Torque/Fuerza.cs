using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuerza : MonoBehaviour
{
    Vector3 p0, p1, pMouse, vFuerza,vAngulos;
    public Vector3 fAplicada;
    float rango = 20;
    float mFuerza;
    public Text mitexto;
    string ystring;

    void Start()
    {
        // [1] Se guarda la posición inicial del extremo en el que se aplica la fuerza.
        p0 = transform.position;
    }

    void OnMouseDrag()
    {
        // [2] Se guarda la posición donde se hizo click.
        pMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, rango);
        // [3] Se convierte la posición al sistema de coordenadas con el que se está trabajando.
        p1 = Camera.main.ScreenToWorldPoint(pMouse);
        // [4] Se mueve la parte en la que se aplica la fuerza.
        transform.position = p1;
    }

    void OnMouseUp()
    {
        // [5] Se calculan las ditancias entre puntos
        vFuerza.x = Mathf.Abs(p1.x - p0.x);
        vFuerza.y = Mathf.Abs(p1.y - p0.y);
        // [6] Se calula la hipotenusa o maditud
        mFuerza = vFuerza.magnitude;
        // [7] Se calculan los ángulos de ese vector.
        vAngulos = vFuerza.normalized;
        // [8] Se extrae sólo fuerza en y: F.y = F*seno(angulo)
        fAplicada.y = (mFuerza * vAngulos.x);

        ystring = fAplicada.y.ToString();
        mitexto.text = ystring;
    }
}
