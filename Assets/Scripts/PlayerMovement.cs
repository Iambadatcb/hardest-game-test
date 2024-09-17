using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        //var - select the type of variable
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        //normalized - move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }
}
