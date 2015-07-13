using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniRx;

public class YushaHpLabel : MonoBehaviour {
	[SerializeField]
	ReactiveYusya yusha;
	[SerializeField]
	Text text;
	
	// Use this for initialization
	void Start	 ()
	{
		yusha.CurrentHP.Subscribe (current =>{
			if (current <= 0)
				text.text =  "勇者は死にました";
			else
				text.text = current + "/" + yusha.MaxHP.Value;
			text.color = current > 0 ? Color.white : Color.red;

		}).AddTo(this);

		yusha.MaxHP.Subscribe (max => text.text = yusha.CurrentHP.Value + "/" + max).AddTo(this);
	}
}
