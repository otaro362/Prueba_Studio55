using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Datos : MonoBehaviour
{
    public GameObject panelMapa;
    public GameObject panelTerreno;
    public GameObject panelRecursos;

    public int tama�oMapa;
    public int tama�oTerreno;

    public SistemaDatos sistemDatosScript;

    public string pathData="data1";
    public string nameFileData="data1";

    public bool cargaDatos;
    private void Start()
    {
        panelMapa = transform.GetChild(1).gameObject;
        panelTerreno = transform.GetChild(2).gameObject;
        panelRecursos = transform.GetChild(5).gameObject;
    }
    public void DatosGuardados()
    {
        sistemDatosScript.tama�oMapa = float.Parse(panelMapa.transform.GetChild(1).GetComponent<TMP_InputField>().text);
        sistemDatosScript.tama�oTerreno = float.Parse(panelTerreno.transform.GetChild(1).GetComponent<TMP_InputField>().text);

        GuardarDatos();
    }
    private void Update()
    {
        if (cargaDatos)
        {
            panelMapa.transform.GetChild(1).GetComponent<TMP_InputField>().text = sistemDatosScript.tama�oMapa.ToString();
            panelTerreno.transform.GetChild(1).GetComponent<TMP_InputField>().text = sistemDatosScript.tama�oTerreno.ToString();
        }


    }
    public void GuardarDatos()
    {
        GuardarCargar.SaveData(sistemDatosScript, pathData, nameFileData);
    }
    public void CargarDatos()
    {
        var datafound = GuardarCargar.LoadData<SistemaDatos>(pathData, nameFileData);
        if (datafound != null)
        {
            print(1);
            sistemDatosScript = datafound;
            cargaDatos = true;
        }
        else
        {
            print(2);
            sistemDatosScript = new SistemaDatos();
            GuardarDatos();
        }
    }
}
