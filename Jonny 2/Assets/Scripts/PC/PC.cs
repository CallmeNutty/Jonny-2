using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    [SerializeField]
    private GameObject PCScreen;

    private bool inZone;

    void OnTriggerEnter2D(Collider2D coll) {inZone = true;}

    void OnTriggerExit2D(Collider2D coll) {inZone = false;}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inZone == true && PCScreen.gameObject.activeInHierarchy == false)
        {
            PCScreen.gameObject.SetActive(true);
            Movement.movementLocked = true;
        }
        else if(Input.GetKeyDown(KeyCode.E) && inZone == true && PCScreen.gameObject.activeInHierarchy == true)
        {
            PCScreen.gameObject.SetActive(false);
            Movement.movementLocked = false;
        }
    }
}
