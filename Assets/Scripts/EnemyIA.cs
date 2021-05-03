using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;

    [SerializeField]
    private GameObject Enemy_explosion;

    private UIManager _uIManager;
    
    void Start()
    {

        _uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -7)
        {
            float newPositionX = Random.Range(-7.6f, 7.6f);
            transform.position = new Vector3(newPositionX, 7.0f, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D otherColl)
    {
        if (otherColl.tag == "Laser")
        {
            if (otherColl.transform.parent != null)
            {
                Destroy(otherColl.transform.parent.gameObject);
            }

            if (_uIManager != null)
            {
                _uIManager.UpdateScore();
            }

            Destroy(otherColl.gameObject);
            Instantiate(Enemy_explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else if(otherColl.tag == "Player")
        {
            Player player = otherColl.GetComponent<Player>();

            if (player != null)
            {
                player.Damage();
            }

            if (_uIManager != null)
            {
                _uIManager.UpdateScore();
            }

            Instantiate(Enemy_explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }
}
