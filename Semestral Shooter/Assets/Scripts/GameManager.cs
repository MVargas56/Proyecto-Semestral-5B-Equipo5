using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerStatus ps;
    public GameObject gameOverScreen;

	void Start () {
        ps = GetComponent<PlayerStatus>();
	}
	
	void Update () {
        if (ps.playerHealth <= 0) {
            GameOver();
        }
	}

    void GameOver() {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Respawn() {
        gameOverScreen.SetActive(false);
        ps.playerHealth = 10;
        Time.timeScale = 1f;
    }
}
