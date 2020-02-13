using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour {

	private GameManager GM;
	private Image equipImage;
	public int mouseType;
	public Sprite equip;
	public Sprite UISprite;

	void Start() {
		GM = (GameManager)FindObjectOfType (typeof(GameManager));
		equipImage = GetComponent<Image> ();
	}

	public void OnEquipButton() {
		int _mouseType = GM.getMouse ().getMouseType ();
		if (equipImage.sprite == equip && _mouseType == 0) {
			equipImage.sprite = UISprite;
			GM.getMouse ().setMouseType (mouseType);
		}
		else if (equipImage.sprite == UISprite && _mouseType == mouseType) {
			equipImage.sprite = equip;
			GM.getMouse ().setMouseType (0);
		}
	}

	void Update() {
		if (mouseType == 1 && GM.getHat () == 1) {
			GM.setHat (0);
			equipImage.sprite = equip;
		}
		else if (mouseType == 2 && GM.getHand() == 1)
		{
			GM.setHand (0);
			equipImage.sprite = equip;
		}
		else if (mouseType == 3 && GM.getShoes() == 1)
		{
			GM.setShoes (0);
			equipImage.sprite = equip;
		}
	}
}
