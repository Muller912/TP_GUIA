using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public int numero;
    public float decimales;
    public string palabra;
    public bool efecto;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numero);
        Debug.Log(decimales);
        Debug.Log(palabra);
        Debug.Log(efecto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
