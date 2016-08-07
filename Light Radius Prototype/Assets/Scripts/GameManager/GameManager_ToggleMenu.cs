using UnityEngine;
using System.Collections;



public class GameManager_ToggleMenu : MonoBehaviour {

    private GameManager_Master gameManagerMaster;

    // Need to cache a reference before an object gets disbled to bring it back
    public GameObject menu; // What gets activated/deactivated

	// Use this for initialization
	void Start () {
        ToggleMenu();
	}
	
	// Update is called once per frame
	void Update () {
        CheckForMenuToggleRequest();
	}

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.GameOverEvent += ToggleMenu;
    }

     void OnDisable()
    {
        gameManagerMaster.GameOverEvent -= ToggleMenu;

    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void CheckForMenuToggleRequest()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn)
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        if (menu != null)
        {
            menu.SetActive(!menu.activeSelf);
            gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
            gameManagerMaster.CallEventMenuToggle();
        }
        else
        {
            Debug.LogWarning(
                "You need to assign a UI GameObject to the Toggle Menu script in the inspector.");
        }
    }
}
