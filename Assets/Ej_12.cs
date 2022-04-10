using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
12.En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
resultados:
• Si los tres dados son seis, mostrar el mensaje “Excelente”
• Si dos dados son seis, mostrar el mensaje “Muy bien”
• Si un dado es seis, mostrar el mensaje “Regular”
• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”
*/

public class Ej_12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;

    void Start()
    {
        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }
        else if (dado1 != 6 && dado2 == 6 && dado3 == 6 || dado1 == 6 && dado2 != 6 && dado3 != 6 || dado1 == 6 && dado2 == 6 && dado3 != 6)
        {
            Debug.Log("Muy bien");
        }
        else if (dado1 == 6 && dado2 != 6 && dado3 != 6 || dado1 != 6 && dado2 == 6 && dado3 != 6 || dado1 != 6 && dado2 != 6 && dado3 == 6)
        {
            Debug.Log("Regular");
        }
        else if (dado1 != 6 && dado2 != 6 && dado3 != 6)
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
