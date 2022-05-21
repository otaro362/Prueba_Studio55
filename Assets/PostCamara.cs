using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostCamara : MonoBehaviour
{
    public Transform posicionCamara;
    // Start is called before the first frame update
    void Start()
    {
        posicionCamara = transform.GetChild(0);
    }
}
