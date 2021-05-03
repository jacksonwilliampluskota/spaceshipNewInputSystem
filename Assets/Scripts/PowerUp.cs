using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    private enum SelectPowerupID
    {
        TRIPLESHOT,
        HIGHSPEED,
        SHIELD
    }
    [SerializeField]
    private SelectPowerupID powerupID;

    //é usado o audio clip quando o audio pode ser interrompido por causa do objeto ser destruido dessa maneira garante que el toque ate o fim
    [SerializeField]
    private AudioClip _clip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -7.0f)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D otherColl)
    {

        if (otherColl.tag == "Player")
        {
            Player player = otherColl.GetComponent<Player>();

            if (player != null)
            {
                AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
                switch (powerupID)
                {
                    case SelectPowerupID.TRIPLESHOT:
                        player.TripleShotPowerUpOn();
                        break;
                    case SelectPowerupID.HIGHSPEED:
                        player.SpeedBoostOn();
                        break;
                    case SelectPowerupID.SHIELD:
                        player.ShieldOn();
                        break;
                    default:
                        break;
                }
                
            }

            Destroy(this.gameObject);
        }
        
    }
}
