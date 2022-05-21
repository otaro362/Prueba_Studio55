using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MapaProcedural : MonoBehaviour
{

    public GameObject prefac;
    public GameObject[] materialPrefac;
    public Vector3 tama�o;
    public int x;
    
    public GameObject mapa;
    public int ubicacionMapa;
    public Button botonGenerador;

    public Vector3 tama�oCasillas;

    public List<GameObject> casillasCreadas=new List<GameObject>();

    public int diamantes;
    public int madera;
    public int metal;
    public int agua;
    public int arena;
    public int vacias;

    public int Guardado;
    public int aleatorio1;

    public TMP_InputField listaACrear;
    
    // Start is called before the first frame update
    public void Start()
    {
        mapa = transform.GetChild(0).gameObject;
        botonGenerador = GameObject.Find("Canvas/Panel/ButtonGenerador").GetComponent<Button>();
        listaACrear= GameObject.Find("Canvas/Panel/InputField (TMP)").GetComponent<TMP_InputField>();
        botonGenerador.onClick.AddListener(AjusteMapa);
        botonGenerador.onClick.AddListener(Generacion);
    }
    //genera los terrenos en orden 
    public void Generacion()
    {
        int numeracion = 0;
        for (int i = 0; i < tama�o.x; i++)
        {
            for (int x = 0; x < tama�o.z; x++)
            {
                
                GameObject cuboCreado = Instantiate(prefac, new Vector3(i * tama�oCasillas.x, 0, x *tama�oCasillas.z), Quaternion.identity, transform);
                cuboCreado.GetComponent<TerrenoProcedural>().tama�o = new Vector3(tama�oCasillas.x,tama�oCasillas.y,tama�oCasillas.z);
                cuboCreado.name = numeracion.ToString();
                cuboCreado.GetComponent<TerrenoProcedural>().diamantes = diamantes;
                cuboCreado.GetComponent<TerrenoProcedural>().madera = madera;
                cuboCreado.GetComponent<TerrenoProcedural>().metal = metal;
                cuboCreado.GetComponent<TerrenoProcedural>().agua = agua;
                cuboCreado.GetComponent<TerrenoProcedural>().arena = arena;
                cuboCreado.GetComponent<TerrenoProcedural>().vacias = vacias;
                cuboCreado.GetComponent<TerrenoProcedural>().aleatorio = aleatorio1;
                cuboCreado.GetComponent<TerrenoProcedural>().Listas = Guardado;
                casillasCreadas.Add(cuboCreado);
                numeracion++;
            }
            
        }
    }
    // ajusta el plano al tama�o de los terrenos 
    public void AjusteMapa()
    {
        ubicacionMapa = (int)(Mathf.Round(tama�o.x * tama�o.z)/2);
        mapa.transform.localScale = new Vector3(tama�o.x+1, 1, tama�o.z+1);
        mapa.transform.position = new Vector3(x + ubicacionMapa, 0, ubicacionMapa);
    }
    private void Update()
    {
        vacias = ((int)((tama�oCasillas.x * tama�oCasillas.z) - diamantes - madera - metal - agua - arena));
    }
    public void SeleccionCreacion(int opcion)
    {
        aleatorio1 = opcion;
        int.TryParse(listaACrear.text, out Guardado);
        Generacion();


    }
}
