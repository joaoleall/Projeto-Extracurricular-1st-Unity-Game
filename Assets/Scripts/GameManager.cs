using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true);
    }

    public void Endgame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);//podia escrever ali dentro 2 segundos
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//"Level1"
    }
}
