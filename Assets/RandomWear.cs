using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomWear : MonoBehaviour {

	private GameManager GM;

	void Start() {
		GM = (GameManager)FindObjectOfType (typeof(GameManager));
	}

	public void OnPress() {
		GM.RandomWear ();
	}
}
