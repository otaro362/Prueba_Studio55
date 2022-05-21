using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;



public class TerrenoProcedural : MonoBehaviour
{
    
    [Serializable]
    public class lista
    {
        public List<GameObject> prefacList = new List<GameObject>();
    }
    public lista prefacList = new lista();

    public GameObject[] prefac;
    
    public Vector3 tamaño;
    public Vector3 pos = Vector3.zero;
    public float[] alturas;
    public int x;
    public int aleatorio;

    public int diamantes;
    public int madera;
    public int metal;
    public int agua;
    public int arena;
    public int vacias;
    public bool guardarMateriales;
    public ScritableDatos scritData;

    public int Listas;

    public bool cargaMateriales;
    public Button botonGuardado;
    public Button botonGuardadoTotal;
    private void Start()
    {
        botonGuardado = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Button>();
        botonGuardado.onClick.AddListener(BotonGenerador);

        botonGuardadoTotal = GameObject.Find("Canvas/Panel/ButtonGuardarTodo").GetComponent<Button>();
        botonGuardadoTotal.onClick.AddListener(BotonGenerador);
        if (aleatorio == 1)
        {
            for (int i = 0; i < diamantes; i++)
            {
                prefacList.prefacList.Add(prefac[0]);
            }
            for (int i = 0; i < madera; i++)
            {
                prefacList.prefacList.Add(prefac[1]);
            }
            for (int i = 0; i < metal; i++)
            {
                prefacList.prefacList.Add(prefac[2]);
            }
            for (int i = 0; i < agua; i++)
            {
                prefacList.prefacList.Add(prefac[3]);
            }
            for (int i = 0; i < arena; i++)
            {
                prefacList.prefacList.Add(prefac[4]);
            }
            for (int i = 0; i < vacias; i++)
            {
                prefacList.prefacList.Add(prefac[5]);
            }
            RamdomArray(prefacList.prefacList);
        }
        else if (aleatorio==2)
        {
            prefacList.prefacList = scritData.cubosMateriales.materiales[Listas].prefacList;
        }
        Generacion();
        
    }
    public void  BotonGenerador() 
    {
        scritData.cubosMateriales.materiales.Add(prefacList);
    }
    public void Generacion()
    {
        alturas = new float[(int)(tamaño.x * tamaño.z)];
        if (aleatorio==0)
        {
            for (int i = 0; i < tamaño.x * tamaño.z; i++)
            {
                x = Random.Range(0, 6);
                Instantiate(prefac[x], Vector3.zero, Quaternion.identity, transform);
            }
        }
        else if (aleatorio==1)
        {
            for (int i = 0; i < tamaño.x * tamaño.z; i++)
            {
                Random.Range(0, tamaño.x * tamaño.z);
                Instantiate(prefacList.prefacList[i], Vector3.zero, Quaternion.identity, transform);
            }
        }
        else if (aleatorio==2)
        {
            for (int i = 0; i < tamaño.x * tamaño.z; i++)
            {
                Instantiate(prefacList.prefacList[i], Vector3.zero, Quaternion.identity, transform);
                print("aleatorio");
            }
        }

        SetAlturas();
    }

    private void SetAlturas()
    {
        for (float z = 0; z < tamaño.z; z++)
        {
            for (float x = 0; x < tamaño.x; x++)
            {
                alturas[(int)x + (int)z * (int)tamaño.x] = 1;
                
            }
        }
        PlanoCubis();
    }

    private void PlanoCubis()
    {
        int i = 1;
        for (pos.z = 0.5f; pos.z < tamaño.z; pos.z++)
        {
            for (pos.x=0.5f;pos.x< tamaño.x;pos.x ++)
            {
                pos.y = alturas[(int)pos.x + (int)pos.z * (int)tamaño.x];
                transform.GetChild(i).localPosition = pos;
                i++;
            }
        }
    }
    public  void RamdomArray(List<GameObject> array)
    {
        int n = array.Count;
        int ramdomValor;
        GameObject temp;
        for (int i = 0; i < n; i++)
        {
            ramdomValor = Random.Range(0, n);
            temp = array[ramdomValor];
            array[ramdomValor] = array[i];
            array[i] = temp;
        }
    }

}