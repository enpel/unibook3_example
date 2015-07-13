using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YushaController : MonoBehaviour {
	[SerializeField]
	ReactiveYusya yusha;

	public void AddDamage()
	{
		yusha.AddDamage ();
	}

	public void LevelUp()
	{
		yusha.LevelUp ();
	}
}
