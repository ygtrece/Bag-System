using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour {

	private GameManager GM;
	private Image bagImage;
	private int mouseType = 0;

	public Sprite UISprite;
	public Sprite hat;
	public Sprite hand;
	public Sprite shoes;

	void Start() {
		GM = (GameManager)FindObjectOfType (typeof(GameManager));
		bagImage = GetComponent<Image> ();
	}

	public void OnBagButton() {
		int _mouseType = GM.getMouse ().getMouseType ();
		Debug.Log (_mouseType);
		if (bagImage.sprite == UISprite && _mouseType != 0) {
			Debug.Log ("put in");
			if (_mouseType == 1) {
				bagImage.sprite = hat;
				GM.getMouse ().setMouseType (0);
			} else if (_mouseType == 2) {
				bagImage.sprite = hand;
				GM.getMouse ().setMouseType (0);
			} else if (_mouseType == 3) {
				bagImage.sprite = shoes;
				GM.getMouse ().setMouseType (0);
			}
		}
		else if (bagImage.sprite == hat)
		{
			if (_mouseType == 0) {
				bagImage.sprite = UISprite;
			}
			else if (_mouseType == 1)
			{
				bagImage.sprite = hat;
			}
			else if (_mouseType == 2)
			{
				bagImage.sprite = hand;
			}
			else if (_mouseType == 3)
			{
				bagImage.sprite = shoes;
			}
			GM.getMouse ().setMouseType (1);
		}
		else if (bagImage.sprite == hand)
		{
			if (_mouseType == 0) {
				bagImage.sprite = UISprite;
			}
			else if (_mouseType == 1)
			{
				bagImage.sprite = hat;
			}
			else if (_mouseType == 2)
			{
				bagImage.sprite = hand;
			}
			else if (_mouseType == 3)
			{
				bagImage.sprite = shoes;
			}
			GM.getMouse ().setMouseType (2);
		}
		else if (bagImage.sprite == shoes)
		{
			if (_mouseType == 0) {
				bagImage.sprite = UISprite;
			}
			else if (_mouseType == 1)
			{
				bagImage.sprite = hat;
			}
			else if (_mouseType == 2)
			{
				bagImage.sprite = hand;
			}
			else if (_mouseType == 3)
			{
				bagImage.sprite = shoes;
			}
			GM.getMouse ().setMouseType (3);
		}
	}
}
