using UnityEngine;

public class pmove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);//so it seem same way in all pcs 
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);

        }
        
        if (rb.position.y < -1){
            FindObjectOfType<Gamemanager>().EndGame(); 
        }
        
    }
}
