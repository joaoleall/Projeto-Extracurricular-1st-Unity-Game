using UnityEngine;

public class PCollision : MonoBehaviour
{
    public PMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name); // diz no que é que batemos
        //if (collisionInfo.collider.name == "Obstacle"){
        if (collisionInfo.collider.tag == "Obstacle"){ //assim vai buscar todos os objetos com tag Obstacle
            Debug.Log("We hit an obstacle");
            //GetComponent<Pmovement>().enabled = false; faria o mesmo
            movement.enabled = false; // o cubo para de mexer assim quando bate no obstaclo, basicamente faz turn off do script pmovement
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
