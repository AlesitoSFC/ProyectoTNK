using UnityEngine;

public class GameTest : MonoBehaviour
{
    void Update()
    {
        // Presiona R para ir a RunScene
        if (Input.GetKeyDown(KeyCode.R))
            GameManager.instance.StartRun();

        // Presiona V para volver a VillageScene
        if (Input.GetKeyDown(KeyCode.V))
            GameManager.instance.ReturnToVillage();
    }
}