using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score { get; private set; }

    public static GameManager instance { get; private set;}

    private void Awake()
    {
        if(instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        ResetLevel();
    }
    private void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }
    public void ResetLevel()
    {
        score = 0;
        LoadLevel();
        
    }
    private void LoadLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void IncreaseScore()
    {
       score += 100;
    }
}
