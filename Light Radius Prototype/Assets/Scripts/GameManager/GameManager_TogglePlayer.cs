using UnityEngine;

public class GameManager_TogglePlayer : MonoBehaviour
{
    public Player playerController;
    public GameObject playerObject;
    private GameManager_Master gameManagerMaster;    

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.MenuToggleEvent += TogglePlayerController;
        gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;

    }

    void OnDisable()
    {
        gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
        gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
    }
	
    void SetInitialReferences() // #Gold
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void TogglePlayerController()
    {
        if(playerController != null)
        {
            playerController.enabled = !playerController.enabled; // #Switch
        }

    }
}
