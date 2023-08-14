using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 0.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;

    public GameObject FacaCyberpunk ;
    
    public float tempoDeDisparo = 0.5f ;
    public float podeDisparar = 0.0f ;

    public bool FacaChamasLigado = false ;
    public GameObject FacaChamas ;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        velocidade = 3.0f ;
        transform.position = new Vector3(-8f,-3.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
       
        Movimento();

        Disparo();

        if (Input.GetKeyDown(KeyCode.Space)){

        
 
        }
       
   }


   private void Movimento(){

       entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);

        if ( transform.position.x  > 8.354f) {
            transform.position = new Vector3(8.354f,transform.position.y,0);
        }

        if ( transform.position.x  < -8.125f  ) {
            transform.position = new Vector3(-8.125f,transform.position.y,0);
        
        }

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*velocidade*entradaVertical);

        if ( transform.position.y  > -2.56f ) {
            transform.position = new Vector3(transform.position.x,-2.56f,0);
        }

        if ( transform.position.y  < -4.16f  ) {
            transform.position = new Vector3(transform.position.x,-4.16f,0);
        }




   }

    private void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > podeDisparar)
            {

                if (FacaChamasLigado == true)
                {

                    Instantiate(FacaChamas, transform.position + new Vector3(-7.108244f, 0, 0), Quaternion.identity);

                }
                else
                {

                    Instantiate(FacaCyberpunk, transform.position + new Vector3(0.74f, 0, 0), Quaternion.identity);
                }






                podeDisparar = Time.time + tempoDeDisparo;
            }


        }
    }
    public IEnumerator FacaChamasRotina()
    {

        yield return new WaitForSeconds(7.0f);

        FacaChamasLigado = false;

    }

    public void LigarFacaChamasPowerUp()
    {

        FacaChamasLigado = true;
        StartCoroutine(FacaChamasRotina());

    }
}


