using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
9.Realizá un programa que resuelva el siguiente problema:
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
por las tres.
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
mostrar lo pedido en el siguiente formato:
Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ ….
*/

public class Ej_9 : MonoBehaviour
{
    public int capital1;
    public int capital2;
    public int capital3;

    public string nombre1;
    public string nombre2;
    public string nombre3;

    int porcentaje1;
    int porcentaje2;
    int porcentaje3;

    int total;

    // Start is called before the first frame update
    void Start()
    {
        total = capital1 + capital2 + capital3;

        porcentaje1 = capital1 * 100 / total;
        porcentaje2 = capital2 * 100 / total;
        porcentaje3 = capital3 * 100 / total;

        Debug.Log(nombre1 + " capital aportado $: " + capital1 + ", porcentaje del capital: %" + porcentaje1 + ", monto total aportado: $ " + total);
        Debug.Log(nombre2 + " capital aportado $: " + capital2 + ", porcentaje del capital: %" + porcentaje2 + ", monto total aportado: $ " + total);
        Debug.Log(nombre3 + " capital aportado $: " + capital3 + ", porcentaje del capital: %" + porcentaje3 + ", monto total aportado: $ " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
