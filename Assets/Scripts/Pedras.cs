using UnityEngine;

public class Pedras : MonoBehaviour
{
	public float velocidade = 3f;
	public float delay = 10f;

	// Use this for initialization
	void Start()
	{
		Destroy(gameObject, delay);
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.left * velocidade * Time.deltaTime);
	}
}
