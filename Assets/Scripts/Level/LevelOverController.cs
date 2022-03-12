using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

       // if (collision.gameObject.CompareTag("Player")    // level is over
       if(collision.gameObject.GetComponent<PlayerController>() !=null)
        { 
            Debug.Log("Level finsihed by the player");
            LevelManager.Instance.MarkCurrentLevelComplete();
        }
    }
}

