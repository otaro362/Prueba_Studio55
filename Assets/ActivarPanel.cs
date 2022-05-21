using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActivarPanel : MonoBehaviour
{

    public Toggle activador;
    public GameObject panelMateriales;
    void Start()
    {
        activador = GetComponent<Toggle>();
        panelMateriales = transform.parent.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (activador.isOn)
        {
            panelMateriales.SetActive(false);
        }
        else
        {
            panelMateriales.SetActive(true);
        }
    }
}
