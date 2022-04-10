using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
13.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
manera:
• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar
el 16)
• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
por cada hora extra. (crear una constante para almacenar el 20)
Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
el salario correspondiente.
*/

public class Ej_13 : MonoBehaviour
{
    int PagaMenos = 16;
    int PagaExtra = 20;
    
    public int horas;
    int HorasExtra;

    int salario;
    int SalarioExtra;

    // Start is called before the first frame update
    void Start()
    {
       if (horas <= 40)
        {
            salario = horas * PagaMenos;
            Debug.Log("El salario correspondiente es: $" + salario);
        }
       else if (horas > 40)
        {
            HorasExtra = (horas - 40);
            SalarioExtra = HorasExtra * PagaExtra;
            salario = 40 * PagaMenos + SalarioExtra;
            Debug.Log("El salario correspondiente es: $" + salario);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
