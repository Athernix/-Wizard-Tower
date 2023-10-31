using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int puntos_totales;
    public int llaves_totales;
    public int vidas;

    private void Awake()
    {
        Instance = this;
    }

    // Métodos para sumar y restar puntos
    public void sumar_puntos(int puntos)
    {
        puntos_totales += puntos;
    }

    public void restar_puntos(int puntos)
    {
        puntos_totales -= puntos;
    }

    // Métodos para sumar y restar llaves
    public void sumar_Llaves(int llaves)
    {
        llaves_totales += llaves;
    }

    public void restar_Llaves(int llaves)
    {
        llaves_totales -= llaves;
    }

    // Métodos para sumar y restar vidas
    public void ganar_vida()
    {
        vidas++;
    }

    public void perder_vida()
    {
        vidas--;
    }

    // Comprueba si el jugador ha muerto
    public bool isDead()
    {
        return vidas <= 0;
    }
}