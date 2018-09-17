using UnityEngine;

public class BulletController : MonoBehaviour {
	public float Speed;
	public float DestroyAfterTime;

	void Update () {
		transform.Translate(Vector3.forward * Speed * Time.deltaTime);

		Destroy(gameObject, DestroyAfterTime);
	}

	private void OnCollisionEnter(Collision other) {
		if (!other.gameObject.CompareTag("Target")) return;

		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
