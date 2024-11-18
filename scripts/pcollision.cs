using UnityEngine;

public class pcollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public pmove movement;

   void OnCollisionEnter (Collision collisionInfo)
   {
     if (collisionInfo.collider.tag == "Obstacle")
     {
        GetComponent<pmove>().enabled = false ; 
        FindObjectOfType<Gamemanager>().EndGame();
        //Debug.Log("we hit");
     }
   }

}