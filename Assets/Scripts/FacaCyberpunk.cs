
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacaCyberpunk : MonoBehaviour
{
   
    public float VelocLaser = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        transform.Translate(Vector3.right * VelocLaser * Time.deltaTime);

        if ( transform.position.x > 9.54f ){

           Destroy(this.gameObject);
        }
        
    }
}
