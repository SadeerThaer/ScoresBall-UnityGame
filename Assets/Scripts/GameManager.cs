using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    
    public float restartDelay = 1f;
    
    public GameObject completeLevelUI;
    public GameObject explosion;
    public Transform player;
    public void CompleteLevel(){
    
        completeLevelUI.SetActive(true);
    }
    
    //Restart as soon as the player loses
    public void EndGame(){
        
        if(gameHasEnded == false){
            Explode();
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Explode(){
        explosion.SetActive(true);
        GameObject expl = Instantiate(explosion, player.position, Quaternion.identity) as GameObject; 
        GameObject.Find("Player").SetActive(false);
        Destroy(expl, 3);
    }
    
    //Repeat game
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
