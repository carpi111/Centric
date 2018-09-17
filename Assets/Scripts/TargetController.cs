using UnityEngine;

public class TargetController : MonoBehaviour {

	private void OnCollisionEnter(Collision other) {
		if (!other.gameObject.CompareTag("Projectile")) return;

		Destroy(gameObject);
	}
}
