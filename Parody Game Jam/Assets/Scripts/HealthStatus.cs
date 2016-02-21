﻿using UnityEngine;
using UnityEngine.UI;

public class HealthStatus : MonoBehaviour {

	public Image[] splats;
	public Image face;
	public Sprite[] faces;

	public Text healthText;
	public Text scoreText;

	private PlayerStatus player;

	void Awake() {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
	}

	public void Update() {
		
		int splatindex = (int)((1 - player.health / player.maxHealth) * (splats.Length-1));
		int faceindex = (int)((1 - player.health / player.maxHealth) * (faces.Length-1));
		splats[splatindex].enabled = true;
		face.sprite = faces[faceindex];

		healthText.text = "Health: " + Mathf.FloorToInt(player.health / player.maxHealth * 100).ToString() + "%";
		scoreText.text = "Score: " + player.score.ToString();
	}
}