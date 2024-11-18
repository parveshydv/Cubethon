 using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    public Transform player;
    public Text scoreText;

    void Update(){
         scoreText.text = player.position.z.ToString("0");


    }
}
