using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoMapa : MonoBehaviour
{
    public TMP_Text totalTerrenos;
    public TMP_Text totalCasillas;
    public TMP_Text totalDiamantes;
    public TMP_Text totalMadera;
    public TMP_Text totalMetal;
    public TMP_Text totalAgua;
    public TMP_Text totalArena;
    public TMP_Text totalVacias;

    public MapaProcedural mapaProceduralScript;
    public CasillasInfo casillasInfoScript;
    // Start is called before the first frame update
    void Start()
    {
        totalTerrenos = transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>();
        totalCasillas = transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>();
        totalDiamantes = transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>();
        totalMadera = transform.GetChild(4).GetChild(0).GetComponent<TMP_Text>();
        totalMetal = transform.GetChild(5).GetChild(0).GetComponent<TMP_Text>();
        totalAgua = transform.GetChild(6).GetChild(0).GetComponent<TMP_Text>();
        totalArena = transform.GetChild(7).GetChild(0).GetComponent<TMP_Text>();
        totalVacias = transform.GetChild(8).GetChild(0).GetComponent<TMP_Text>();
        mapaProceduralScript = GameObject.Find("Mapa").GetComponent<MapaProcedural>();
        casillasInfoScript = mapaProceduralScript.gameObject.GetComponent<CasillasInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        totalTerrenos.text = (mapaProceduralScript.tamaño.x * mapaProceduralScript.tamaño.z).ToString();
        totalCasillas.text = ((mapaProceduralScript.tamañoCasillas.x * mapaProceduralScript.tamañoCasillas.z) * (mapaProceduralScript.tamaño.x * mapaProceduralScript.tamaño.z)).ToString();
        totalDiamantes.text = casillasInfoScript.totalDiamantes.ToString();
        totalMadera.text = casillasInfoScript.totalMadera.ToString();
        totalMetal.text = casillasInfoScript.totalMetal.ToString();
        totalAgua.text = casillasInfoScript.totalAgua.ToString();
        totalArena.text = casillasInfoScript.totalArena.ToString();
        totalVacias.text = casillasInfoScript.totalVacias.ToString();
    }

}