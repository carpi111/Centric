using UnityEngine;

public class GunController : MonoBehaviour {
	public BulletController Bullet;
	public float BulletSpeed;

	private float _shotCounter;

	public Transform FirePoint;

	public Material OriginalMaterial;
	public Material CurrentMaterial;

	public Material[] Materials;
	public int CurrentMaterialIndex;

	private void Start() {
		CurrentMaterial = OriginalMaterial;
	}

	void Update () {
		if (!Input.GetMouseButtonDown(1)) return;

		if (++CurrentMaterialIndex >= Materials.Length) {
			CurrentMaterialIndex = 0;
		}

		CurrentMaterial = Materials[CurrentMaterialIndex];
	}

	public void FireBullet() {
			var newBullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
			newBullet.GetComponent<Renderer>().material = CurrentMaterial;
			newBullet.Speed = BulletSpeed;
	}
}
