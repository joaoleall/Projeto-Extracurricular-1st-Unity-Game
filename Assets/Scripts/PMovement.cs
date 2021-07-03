//using System.Collections.Generic; listas
using UnityEngine;

public class PMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
     {

     }

    // Update is called once per frame
    //Se usarmos fisica por FixedUpdate e não Update
    void FixedUpdate()
    {
        //Assim deixa meter a força no unity
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);// depende das frames do pc e isto basicamente mete o pc que é rapido mais lento

        if( Input.GetKey("d")){
            //para andar para a direita
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if( Input.GetKey("a")){
            //para andar para a direita
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
