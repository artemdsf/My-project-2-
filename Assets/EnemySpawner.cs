using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] private Transform[] _spawnPoints;
	[SerializeField] private EnemyMovement _enemyPrefab;
	[SerializeField] private Vector3 _direction;
	[SerializeField] private float _spawnInterval = 2.0f;

	private float _spawnTimer = 0.0f;

	private void Update()
	{
		_spawnTimer += Time.deltaTime;

		if (_spawnTimer >= _spawnInterval)
		{
			SpawnEnemy();
			_spawnTimer = 0.0f;
		}
	}

	private void SpawnEnemy()
	{
		int randomSpawnPointIndex = Random.Range(0, _spawnPoints.Length);
		Transform spawnPoint = _spawnPoints[randomSpawnPointIndex];

		EnemyMovement newEnemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);

		newEnemy.SetDirection(_direction);
	}
}
