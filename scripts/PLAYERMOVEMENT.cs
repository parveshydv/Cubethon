using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        
    }
}
