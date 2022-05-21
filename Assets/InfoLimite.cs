using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoLimite : MonoBehaviour
{
    public GameObject panelInfo;
    public Button botonGenerador;
    public MapaProcedural mapaProceduralScript;
    public Button botonPanelGuardado;
    public GameObject panelGuardado;
    // Start is called before the first frame update
    void Start()
    {
        panelInfo = transform.GetChild(6).gameObject;
        botonGenerador = transform.GetChild(0).GetComponent<Button>();
        mapaProceduralScript = GameObject.Find("Mapa").GetComponent<MapaProcedural>();
        panelGuardado = transform.parent.GetChild(1).gameObject;
        panelGuardado.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(PanelGuardado);
    }

    // Update is called once per frame
    void Update()
    {
        if (mapaProceduralScript.vacias<0)
        {
            panelInfo.SetActive(true);
            botonGenerador.interactable = false;
        }
        else
        {
            panelInfo.SetActive(false);
            botonGenerador.interactable = true;
        }
    }
    public void PanelGuardado()
    {
        if (panelGuardado.activeSelf)
        {
            panelGuardado.SetActive(false);
        }
        else
        {
            panelGuardado.SetActive(true);
        }
    }
}
