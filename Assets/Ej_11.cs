using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
11.Realizá un programa que resuelva el siguiente problema:
Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
Modelo de Ticket:
Fecha de Compra: YYYYMMDD
Nombre del Comprador: xxxxx xxxxx
Producto solicitado: xxxxx
Cantidad solicitada: xx
Precio Unitario: $xxx
Total a Pagar: $xxxxx
*/

public class Ej_11 : MonoBehaviour
{
    public string FechaCompra;

    public string nombre;

    public string NombreProducto;

    public int cantidad;

    public float precio;

    float MontoAPagar;

    // Start is called before the first frame update
    void Start()
    {
        MontoAPagar = precio * cantidad;

        Debug.Log("Fehca de compra: " + FechaCompra);
        Debug.Log("Nombre del comprador: " + nombre);
        Debug.Log("Producto solicitado: " + NombreProducto);
        Debug.Log("Cantidad solicitada: " + cantidad);
        Debug.Log("Precio unitario: " + precio);
        Debug.Log("Total a pagar: " + MontoAPagar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
