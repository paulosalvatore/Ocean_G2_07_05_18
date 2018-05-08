using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
	public Rigidbody2D rb;

	public float forcaPulo = 300f;

	public Text pontosText;
	private int pontos = 0;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Pular();
		}
	}

	private void Pular()
	{
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.up * forcaPulo);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("ColisorPontos"))
		{
			pontos = pontos + 1;
			pontosText.text = "Pontos: " + pontos;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Pedras"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
