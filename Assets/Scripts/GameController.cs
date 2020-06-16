using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   public bool isAlive = true;
   public bool gameStarted;

   public int currentScore = 0;
   public TextController textController;


   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Escape)) {
            
         // Quit the application
         SceneManager.LoadScene(0);
      }
      
   }
   
   public void RestartLevel()
   {
      StartCoroutine(EndGame());
   }

   public void AddScore()
   {
      currentScore++;
      textController.UpdateScore();
   }
   
   IEnumerator EndGame()
   {
      if(currentScore > PlayerPrefs.GetInt("HiScore"))
      PlayerPrefs.SetInt("HiScore",currentScore);
      
      
      yield return new WaitForSeconds(3);
      
      SceneManager.LoadScene(1);
   }
}
