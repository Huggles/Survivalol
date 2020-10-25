using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
		
	[Range(1, 10)] [SerializeField] public float MovementMultiplier = 5f;

	private Rigidbody m_Rigidbody;
	private Vector3 m_Velocity = Vector3.zero;

	private void Awake()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
	}
	private void FixedUpdate()
	{
		Move();
	}


	public void Move()
	{
		
		float xMovement = Input.GetAxis("Horizontal");
		float yMovement = Input.GetAxis("Vertical");
		m_Rigidbody.velocity = new Vector2(xMovement, yMovement) * MovementMultiplier;
	}
}
