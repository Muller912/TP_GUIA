using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre;
    public int edad;
    public float estatura;
    public bool donantedeorganos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + " tengo " + edad + " , mido " + estatura + " metros y es " + donantedeorganos + " que soy donante de organos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
