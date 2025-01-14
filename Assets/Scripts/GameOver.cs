using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Transform player;
    public float gameOverY = -10f;
    public GameObject gameOverUI;
    public Text countdownText;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if (player.position.y < gameOverY)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverUI.SetActive(true);
        StartCoroutine(StartCountdown());
    }

    System.Collections.IEnumerator StartCountdown()
    {
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = $"Restart in: {i}";
            yield return new WaitForSeconds(1f);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
