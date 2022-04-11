using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema2 : MonoBehaviour
{
    public string Nombre;
    public int Año;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (Nombre == "")
        {
            Debug.Log("Error. Campo nombre vacío");
        }

        else if (Año < 1 || Año > 5)
        {
            Debug.Log("Error. El año debe estar entre 1 y 5");
        }

        else if (Año < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }

        else
        {
            switch (orientacion)
            {
                case "T":
                    Debug.Log("Muchas gracias " + Nombre + "!");
                    break;

                case "D":
                    Debug.Log("Muchas gracias " + Nombre + "!");
                    break;

                case "G":
                    Debug.Log("Muchas gracias " + Nombre + "!");
                    break;

                case "M":
                    Debug.Log("Muchas gracias " + Nombre + "!");
                    break;

                case "H":
                    Debug.Log("Muchas gracias " + Nombre + "!");
                    break;

                default:
                    Debug.Log("Solo puede ingresar T, D, G, M o H");
                    break;
            }
        }        
    }
}
