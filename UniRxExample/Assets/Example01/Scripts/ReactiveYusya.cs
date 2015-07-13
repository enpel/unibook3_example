using UnityEngine;
using System.Collections;
using UniRx;

public class ReactiveYusya : MonoBehaviour {
	public ReactiveProperty<int> Level { get; private set; } 
	public ReactiveProperty<int> CurrentHP { get; private set; }
	public ReactiveProperty<int> MaxHP { get; private set;   }

	void Awake ()
	{
		Level = new ReactiveProperty<int> ();
		CurrentHP = new ReactiveProperty<int> ();
		MaxHP = new ReactiveProperty<int> ();

		Level.Value = 1;
		MaxHP.Value = 20;
		CurrentHP.Value = MaxHP.Value; 

		Level.Subscribe (level => {
			MaxHP.Value = 20 + level;
			CurrentHP.Value = MaxHP.Value;
		}).AddTo (this);
	}

	public void AddDamage()
	{
		CurrentHP.Value --;
	}
	
	public void LevelUp()
	{
		Level.Value ++;
	}
}

