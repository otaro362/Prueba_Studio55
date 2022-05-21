using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materiale : MonoBehaviour
{
    public List<GameObject> metal=new List<GameObject>();
    public List<GameObject> madera= new List<GameObject>();
    public List<GameObject> arena= new List<GameObject>();
    public List<GameObject> agua= new List<GameObject>();
    public List<GameObject> diamantes= new List<GameObject>();
    public List<GameObject> vacio = new List<GameObject>();
    public CasillasInfo casillasInfoScript;
    // Start is called before the first frame update
    void Start()
    {

        casillasInfoScript = GetComponentInParent<CasillasInfo>();
        for (int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).tag);
            if (transform.GetChild(i).tag == "Metal")
            {
                metal.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalMetal++;
            }
            else if (transform.GetChild(i).tag == "Agua")
            {
                agua.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalAgua++;
            }
            else if (transform.GetChild(i).tag == "Arena")
            {
                arena.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalArena++;
            }
            else if (transform.GetChild(i).tag == "Diamante")
            {
                diamantes.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalDiamantes++;
            }
            else if (transform.GetChild(i).tag == "Madera")
            {
                madera.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalMadera++;
            }
            else if(transform.GetChild(i).tag=="Vacios")
            {
                vacio.Add(transform.GetChild(i).gameObject);
                casillasInfoScript.totalVacias++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
