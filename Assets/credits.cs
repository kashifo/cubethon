using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public void Quit(){
        Debug.Log("Quitting");
    	Application.Quit();
    }

    public void PlayAgain(){
        Debug.Log("PlayAgain");
        SceneManager.LoadScene("Level01");
    }
}
