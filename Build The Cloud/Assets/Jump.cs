using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{
	Rigidbody2D rigid;
	float timer = 0.0f;

	void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > 2.5f)
		{
			timer = 0.0f;
			rigid.AddForce(new Vector2(0.0f, 200.0f));
		}
	}
}
