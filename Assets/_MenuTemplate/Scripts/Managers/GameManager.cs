﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameSettings gameSettings;
	public GameEvent onGameStart;
	public GameEvent onGamePlaying;
	public GameEvent onGameReset;

	private void Awake () {

	}

	void Start () {
		if (onGameStart != null)
			onGameStart.Raise ();
	}
}