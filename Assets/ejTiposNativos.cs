using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ejTiposNativos : MonoBehaviour
{
    public float miFloat;
    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundoEnLaConsola();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirParametroEnConsola("El martes se entrega los juegos");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            string num = ObtenerParteEnteraEnstring(miFloat);

            EscribirParametroEnConsola(num);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {

            EscribirParametroEnConsola(Enteros(num1, num2, num3).ToString());
        }
    }



    //1.1 Definir una función que escriba en consola “Hola Mundo!” al ser invocada.Invocar la función al presionar la barra espaciadora.
    void HolaMundoEnLaConsola()// es void porq no devuelve nada
    {
        Debug.Log("Hola Mundo!");
    }



    //1.2 Definir una función que escriba en consola la cadena pasada por parámetro.

    void EscribirParametroEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }

    //1.4 Recibe un float por parámetro y lo procesa para devolver la parte entera como un string. Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.

    string ObtenerParteEnteraEnstring(float num)
    {
        string retorno = "";

        retorno = Mathf.Floor(num).ToString(); //para que solo devuelva los enteros del float

        return retorno;
    }

    //1.5 Definir una función que reciba tres enteros y devuelva el mayor de ellos.Si son los tres iguales retornar -1.  
    //Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.

    int Enteros (int num1, int num2, int num3)
    {
        
        if (num1>num2 && num1 > num3)
        {
            return num1;
        }

        else if (num2 > num1 && num2 > num3)
        {
            return num2;
        }

        else if (num3>num1 && num2 > num1)
        {
            return num3;
        }

        else
        {
            return -1;
        }
    }
}
