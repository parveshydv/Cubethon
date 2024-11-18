using UnityEngine;
using UnityEngine.SceneManagement ;

public class Gamemanager : MonoBehaviour
{
    // Start is called once before the first ex ecution of Update after the MonoBehaviour is created
    bool gameEnded = false;
    public float restartDelay = 1f;
    
    public GameObject CompleteLevelUI;
    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true); 
        //Debug.Log("game won");
        
    }



    public void EndGame()
    { 
       if (gameEnded==false){
        gameEnded = true;
        Debug.Log("game over");
        Invoke("Restart",restartDelay );
        //restart game
         }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
