using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit(){
    
        //Game is finished
        Application.Quit();
    
    }

    public void Restart(){
    
        //Game is finished
        SceneManager.LoadScene("Menu");
    
    }
}
