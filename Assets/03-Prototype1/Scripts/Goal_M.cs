using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_M : MonoBehaviour
{

    static public bool goalMet = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Goal_M.goalMet = true;
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }

}
