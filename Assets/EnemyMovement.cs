using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 5.0f;

	private Transform _target;

	public void SetTarget(Transform target)
	{
		_target = target;
	}

	private void Update()
	{
		Vector3 direction = (_target.position - transform.position).normalized;
		transform.Translate(_moveSpeed * Time.deltaTime * direction);
	}
}
