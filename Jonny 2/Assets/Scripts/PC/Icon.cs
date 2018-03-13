using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icon : MonoBehaviour
{ 
    [SerializeField]
    private GameObject pcInterface;

    public void ToApp(GameObject app)
    {
        app.SetActive(true);
        pcInterface.SetActive(false);
    }
}
