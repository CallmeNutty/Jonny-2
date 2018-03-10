using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    private bool inZone;

    void OnTriggerEnter2D(Collider2D coll) {inZone = true;}

    void OnTriggerExit2D(Collider2D coll) {inZone = false;}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inZone == true)
        {
            print("Wetfarts");
        }
    }
}
