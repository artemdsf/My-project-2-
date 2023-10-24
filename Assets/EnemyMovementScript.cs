using System.Diagnostics;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 5.0f;

	private Vector3 _moveDirection;

	public void SetDirection(Vector3 direction)
	{
		_moveDirection = direction.normalized;
	}

	private void Update()
	{
		transform.Translate(_moveSpeed * Time.deltaTime * _moveDirection);
	}
}
