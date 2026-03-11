using TMPro;
using UnityEngine;

public class GemCollector : MonoBehaviour
{
    public static GemCollector Instance;

    [SerializeField] private int gem = 0;
    [SerializeField] private TextMeshProUGUI gemText;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        gemText.text = "X " + gem.ToString();
    }

    public void AddGem()
    {
        gem++;
    }
}
