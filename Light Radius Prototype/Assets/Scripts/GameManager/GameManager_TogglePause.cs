using UnityEngine;
using System.Collections;

public class GameManager_TogglePause : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    private bool isPaused;

    // Use this for initialization
    void OnEnable()
    {

    }
    void OnDisable()
    {

    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else Time.timeScale = 0;
        isPaused = true;
    }
}
