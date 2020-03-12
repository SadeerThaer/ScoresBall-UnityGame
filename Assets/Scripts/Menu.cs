using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   //Startscreen with button appears
   public void StartGame(){
    
     

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
   }

   void FixedUpdate(){
      if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
   }
}
