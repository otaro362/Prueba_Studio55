using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Data", menuName = "DataList", order = 1)]
public class ScritableDatos : ScriptableObject
{

    [Serializable]
    public class ListaListaCubos
    {
        public List<TerrenoProcedural.lista> materiales = new List<TerrenoProcedural.lista>();
    }
    public ListaListaCubos cubosMateriales = new ListaListaCubos();
}
