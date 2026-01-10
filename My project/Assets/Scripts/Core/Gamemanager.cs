using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

private void Awake()
{
    if (instance == null)
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("GameManager activado"); // <- este es el mensaje de prueba
    }
    else
    {
        Destroy(gameObject);
    }
}

    public void StartRun()
{
    SceneManager.LoadScene("RunScene");
}

public void ReturnToVillage()
{
    SceneManager.LoadScene("VillageScene");
}
}