using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniRx;

public class YushaLvLabel : MonoBehaviour {
	[SerializeField]
	ReactiveYusya yusha;
	[SerializeField]
	Text text;

	// Use this for initialization
	void Start ()
	{
		yusha.Level.Subscribe (level => text.text = "Lv: " + level).AddTo(this);
	}
}
