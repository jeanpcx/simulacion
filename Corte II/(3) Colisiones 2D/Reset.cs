using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Multiples esferas");
    }
    public void reset()
    {
        SceneManager.LoadScene("2 esferas");
    }

}