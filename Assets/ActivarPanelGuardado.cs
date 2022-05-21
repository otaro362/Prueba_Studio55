using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarPanelGuardado : MonoBehaviour
{
    public GameObject panelGuardar;
    public GameObject panelCarga;
    public Button botonGuardado;
    public Button botonCarga;
    public Datos datosScript;
       // Start is called before the first frame update
    void Start()
    {
        datosScript = transform.parent.GetChild(0).GetComponent<Datos>();
        panelGuardar = transform.GetChild(4).gameObject;
        panelCarga = transform.GetChild(5).gameObject;
        botonGuardado = transform.GetChild(1).GetComponent<Button>();
        botonGuardado.onClick.AddListener(ActivarGuardado);
        botonCarga = transform.GetChild(2).GetComponent<Button>();
        botonCarga.onClick.AddListener(ActivarCarga);
        panelGuardar.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(ActivarGuardado);
        panelGuardar.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(datosScript.DatosGuardados);
        panelCarga.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(ActivarCarga);
        panelCarga.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(datosScript.CargarDatos);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarGuardado()
    {
        if (panelGuardar.activeSelf)
        {
            panelGuardar.SetActive(false);
        }
        else
        {
            panelGuardar.SetActive(true);
        }
    }
    public void ActivarCarga()
    {
        if (panelCarga.activeSelf)
        {
            panelCarga.SetActive(false);
        }
        else
        {
            panelCarga.SetActive(true);
        }
    }
}
