using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelMateriales : MonoBehaviour
{
    public TMP_InputField diamante;
    public TMP_InputField madera;
    public TMP_InputField metal;
    public TMP_InputField agua;
    public TMP_InputField arena;

    public int diamanteInt;
    public int maderaInt;
    public int metalInt;
    public int aguaInt;
    public int arenaInt;

    public MapaProcedural mapaProceduralScript;

    // Start is called before the first frame update
    void Start()
    {
        mapaProceduralScript = GameObject.Find("Mapa").GetComponent<MapaProcedural>();
        diamante = transform.GetChild(0).GetChild(1).GetComponent<TMP_InputField>();
        madera = transform.GetChild(1).GetChild(1).GetComponent<TMP_InputField>();
        metal = transform.GetChild(2).GetChild(1).GetComponent<TMP_InputField>();
        agua = transform.GetChild(3).GetChild(1).GetComponent<TMP_InputField>();
        arena = transform.GetChild(4).GetChild(1).GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        int.TryParse(diamante.text, out diamanteInt);
        int.TryParse(madera.text, out maderaInt);
        int.TryParse(metal.text, out metalInt);
        int.TryParse(agua.text, out aguaInt);
        int.TryParse(arena.text, out arenaInt);

        mapaProceduralScript.diamantes = diamanteInt;
        mapaProceduralScript.madera = maderaInt;
        mapaProceduralScript.metal = metalInt;
        mapaProceduralScript.agua = aguaInt;
        mapaProceduralScript.arena = arenaInt;
    }
}
