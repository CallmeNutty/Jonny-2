using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour {

    [SerializeField]
    private GameObject pcInterface;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            pcInterface.SetActive(true);
            gameObject.SetActive(false);
        }
	}
}
