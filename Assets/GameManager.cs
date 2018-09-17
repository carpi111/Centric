using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Player;

	private void Start() {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
}
