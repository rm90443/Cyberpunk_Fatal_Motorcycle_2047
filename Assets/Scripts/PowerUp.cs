using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    [SerializeField]
    private float _velocidade = 10.0f;


    void Start()
    {


    }


    void Update()
    {

        transform.Translate(Vector3.left * _velocidade * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("O objeto " + name + " colodiu com o objeto " + other.name);

        if (other.tag == "Player")

        {
            Player player = other.GetComponent<Player>();

            if (player != null)

            {

                player.LigarFacaChamasPowerUp();

                Destroy(this.gameObject);

            }
        }
    }


}
