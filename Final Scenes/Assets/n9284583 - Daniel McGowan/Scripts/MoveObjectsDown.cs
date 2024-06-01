using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectsDown : MonoBehaviour
{
	public GameManager gameManager;
	public GameObject[] objectsToMove;
	public float moveDistance = 5f;
	public float moveSpeed = 2f;

	private bool hasMoved = false;

	void Update()
	{
		if (gameManager.levelComplete && !hasMoved)
		{
			StartCoroutine(MoveObjects());
			hasMoved = true;
		}
	}

	private IEnumerator MoveObjects()
	{
		Vector3[] originalPositions = new Vector3[objectsToMove.Length];
		for (int i = 0; i < objectsToMove.Length; i++)
		{
			originalPositions[i] = objectsToMove[i].transform.position;
		}

		float elapsedTime = 0;
		while (elapsedTime < moveDistance / moveSpeed)
		{
			for (int i =0; i < objectsToMove.Length; i++)
			{
				objectsToMove[i].transform.position = Vector3.Lerp(originalPositions[i], originalPositions[i] - new Vector3(0, moveDistance, 0), (elapsedTime * moveSpeed) / moveDistance);
			}
			elapsedTime += Time.deltaTime;
			yield return null;
		}

		for (int i = 0; i < objectsToMove.Length; i++)
		{
			objectsToMove[i].transform.position = originalPositions[i] - new Vector3(0, moveDistance, 0);
		}
	}
}