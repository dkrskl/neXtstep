using System;
using UnityEngine;

public class TextController : MonoBehaviour
{
    [SerializeField] private TextMesh score;
    [SerializeField] private TextMesh timer;

    private PlayerMove playerController;
    
    private float actualTimer = 45;

    private float customTimer = 0.0f;

    public GameController gameController;
    void Start()
    {
        score.text = gameController.currentScore.ToString();
        
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerMove>();

    }
    
    void Update()
    {
        if (!gameController.isAlive || !gameController.gameStarted)
            return;
        
        if (actualTimer < 0.01f)
        {
            timer.text = 0.00f.ToString();
            playerController.Die();
            return;
        }

        customTimer += Time.deltaTime;
        actualTimer = (45 - customTimer);
        timer.text = actualTimer.ToString().Substring(0, 5);
    }

    public void UpdateScore()
    {
        score.text = gameController.currentScore.ToString();
    }
}
