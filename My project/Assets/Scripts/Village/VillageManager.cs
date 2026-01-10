using UnityEngine;

public class VillageManager : MonoBehaviour
{
    public int oro = 0;
    public int madera = 0;
    public int comida = 0;

    private void Start()
    {
        Debug.Log("VillageManager activado");
        MostrarRecursos();
    }

    public void MostrarRecursos()
    {
        Debug.Log("Oro: " + oro + " | Madera: " + madera + " | Comida: " + comida);
    }

    // Métodos para sumar recursos (puedes llamarlos más adelante)
    public void AgregarOro(int cantidad)
    {
        oro += cantidad;
        MostrarRecursos();
    }

    public void AgregarMadera(int cantidad)
    {
        madera += cantidad;
        MostrarRecursos();
    }

    public void AgregarComida(int cantidad)
    {
        comida += cantidad;
        MostrarRecursos();
    }
}
