using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoTerrenos : MonoBehaviour
{
    public TMP_Text NumeroTerreno;
    public TMP_Text totalCasillas;
    public TMP_Text totalDiamantes;
    public TMP_Text totalMadera;
    public TMP_Text totalMetal;
    public TMP_Text totalAgua;
    public TMP_Text totalArena;
    public TMP_Text totalVacias;

    public GameManager gameManager;
    public MapaProcedural mapaProceduralScrip;

    // Start is called before the first frame update
    void Start()
    {
        totalCasillas = transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>();
        totalDiamantes = transform.GetChild(2).GetChild(0).GetComponent<TMP_Text>();
        totalMadera = transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>();
        totalMetal = transform.GetChild(4).GetChild(0).GetComponent<TMP_Text>();
        totalAgua = transform.GetChild(5).GetChild(0).GetComponent<TMP_Text>();
        totalArena = transform.GetChild(6).GetChild(0).GetComponent<TMP_Text>();
        totalVacias= transform.GetChild(7).GetChild(0).GetComponent<TMP_Text>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        mapaProceduralScrip = GameObject.Find("Mapa").GetComponent<MapaProcedural>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.terrenoSeleccionado!=null)
        {
            totalCasillas.text = (mapaProceduralScrip.tamañoCasillas.x * mapaProceduralScrip.tamañoCasillas.z).ToString();
            totalDiamantes.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().diamantes.Count.ToString();
            totalMadera.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().madera.Count.ToString();
            totalMetal.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().metal.Count.ToString();
            totalAgua.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().agua.Count.ToString();
            totalArena.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().arena.Count.ToString();
            totalVacias.text = gameManager.terrenoSeleccionado.GetComponent<Materiale>().vacio.Count.ToString();
        }

    }
}
