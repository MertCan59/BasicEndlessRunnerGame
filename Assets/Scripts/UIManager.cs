using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{ 
    
    [SerializeField] private TextMeshProUGUI text;
    public static UIManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        WriteScore();
    }
    public void WriteScore()
    {
            text.text = GameManager.instance.score.ToString();
    }
}
