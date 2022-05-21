using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int casillaLargoInt;
    public TMP_InputField largoCasillas;

    public TerrenoProcedural terrenoProceduralScrip;
    public MapaProcedural mapaProceduralScrip;

    public int terrenoLargoInt;
    public TMP_InputField terrenoLargo;

    public Camera camara;
    public CinemachineVirtualCamera cmCamera;

    public Button botonGenerador;

    public GameObject terrenoSeleccionado;

    public ScritableDatos dataList;

    // Start is called before the first frame update
    void Start()
    {
        mapaProceduralScrip = GameObject.Find("Mapa").GetComponent<MapaProcedural>();
        largoCasillas = GameObject.Find("Canvas/Panel/PanelTerreno/TamañoTerreno").GetComponent<TMP_InputField>();
        terrenoLargo = GameObject.Find("Canvas/Panel/PanelMapa/TamañoMapa").GetComponent<TMP_InputField>();

        camara = GameObject.Find("Main Camera").GetComponent<Camera>();
        cmCamera = GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();

        botonGenerador = GameObject.Find("Canvas/Panel/ButtonGenerador").GetComponent<Button>();
        botonGenerador.onClick.AddListener(AjusteCamara);
    }

    // Update is called once per frame
    void Update()
    {

        int.TryParse(terrenoLargo.text, out terrenoLargoInt);
        mapaProceduralScrip.tamaño = new Vector3(terrenoLargoInt, terrenoLargoInt, terrenoLargoInt);

        int.TryParse(largoCasillas.text, out casillaLargoInt);
        mapaProceduralScrip.tamañoCasillas = new Vector3(casillaLargoInt, casillaLargoInt, casillaLargoInt);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                cmCamera.Follow = hit.collider.gameObject.transform.GetComponentInParent<PostCamara>().posicionCamara;
                cmCamera.m_Lens.OrthographicSize = mapaProceduralScrip.tamaño.x+1;
                terrenoSeleccionado = hit.collider.transform.parent.gameObject; 
                print(hit.collider.gameObject.name);
            }

        }
    }
    public void AjusteCamara()
    {
        cmCamera.m_Lens.OrthographicSize = terrenoLargoInt * terrenoLargoInt;
        print(1);
    }
}
