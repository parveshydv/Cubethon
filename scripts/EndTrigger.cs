using UnityEngine;

public class EndTrigger : MonoBehaviour
{    
    public Gamemanager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        
    }

    
}
