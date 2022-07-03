using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        Destroy(gameObject, 5f);
        _rigidbody = GetComponent<Rigidbody2D>(); 
        _rigidbody.velocity = transform.forward * _speed;
    }

    private void Update()
    {
        // transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.World);
        //_rigidbody.velocity = transform.forward * _speed; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }
    }
}
