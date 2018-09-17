using UnityEngine;

public class PlayerController : MonoBehaviour {
	public GunController Gun;

	private readonly Vector3 _yAxis = new Vector3(0f, 1f, 0f);

	void Start () {
		transform.Rotate(_yAxis, 90f);
	}

	void Update () {
		RotatePlayerInHexagon();

		FireBullets();
	}

	private void FireBullets() {
		if (Input.GetMouseButtonDown(0)) {
			Gun.FireBullet();
		}
	}

	private void RotatePlayerInHexagon() {
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) {
			transform.Rotate(_yAxis, 180f);
		} else if (Input.GetKeyDown(KeyCode.A)) {
			transform.Rotate(_yAxis, -60f);
		} else if (Input.GetKeyDown(KeyCode.D)) {
			transform.Rotate(_yAxis, 60f);
		}
	}
}
