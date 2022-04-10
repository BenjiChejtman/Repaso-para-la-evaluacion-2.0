using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
15.Existen dos reglas que identifican dos conjuntos de valores:
-El número es de un solo dígito.
- El número es impar.
A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
escribiendo los resultados.
*/

public class Ej_15 : MonoBehaviour
{
    bool EstaEnA = false;
    bool EstaEnB = false;
    bool EstaEnAmbas = false;
    bool NoEstaEnNinguna = false;

    public int num1;

    void Start()
    {
        if (num1 < 10 && num1 % 2 > 0)
        {
            EstaEnAmbas = true;
            Debug.Log(num1 + " es impar y contiene un solo digito.");
        }
        else if (num1 < 10)
        {
            EstaEnA = true;
            Debug.Log(num1 + " contiene un solo digito.");
        }
        else if (num1 % 2 > 0)
        {
            EstaEnB = true;
            Debug.Log(num1 + " es impar.");
        }
        else if (num1 > 10 && num1 % 2 == 0)
        {
            NoEstaEnNinguna = true;
            Debug.Log(num1 + " no es impar y contiene mas de un digito.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
