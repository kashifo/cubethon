using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void ExitGam(){
        Debug.Log("Quitting");
    	Application.Quit();
    }

    public void Play(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
