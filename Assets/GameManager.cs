using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private MouseImage mouse;
	private int IsHat = 0;
	private int IsHand = 0;
	private int IsShoes = 0;

	void Start() {
		mouse = (MouseImage)FindObjectOfType (typeof(MouseImage));
	}

	public MouseImage getMouse() {
		return mouse;
	}

	public void setMouse(MouseImage m) {
		if (mouse == null) {
			mouse = m;
		}
	}

	public void RandomWear() {
		IsHat = 1;
		IsHand = 1;
		IsShoes = 1;
	}

	public int getHat() { return IsHat; }
	public int getHand() { return IsHand; }
	public int getShoes() { return IsShoes; }

	public void setHat(int h) { IsHat = h; }
	public void setHand(int h) { IsHand = h; }
	public void setShoes(int s) { IsShoes = s; }
}
