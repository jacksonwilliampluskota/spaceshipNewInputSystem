using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    public int lives = 3;

    [SerializeField]
    private bool _speeBoost = false;

    [SerializeField]
    private GameObject _lazerPrefab;
    [SerializeField]
    private GameObject _triplelazerPrefab;

    //new input Actions
    private PlayerInputActions _inputActions;
    private Vector2 _movementInput;
    private Vector2 _lookpossition;

    [SerializeField]
    private float _fireRate = 0.25f;
    private float _canFire = 0.0f;

    public bool canTripleShoot = false;

    [SerializeField]
    private bool _hasShield = false;

    [SerializeField]
    private GameObject _explosion_prefab;

    [SerializeField]
    private GameObject _shieldGameObject;

    private UIManager _uiManager;
    private GameManager _gameManager;
    private SpawnManager _spawnManager;

    [SerializeField]
    private GameObject[] _fireHurt;

    private int hurtCount = 0;

    public bool playerOne = false;
    public bool playerTwo = false;

    private void Awake()
    {
        _inputActions = new PlayerInputActions();
        
        
        if (playerOne)
        {
            _inputActions.PlayerControls.Move.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
            _inputActions.PlayerControls.Shoot.performed += _ => Shoot();
        }

        if(playerTwo)
        {
            _inputActions.PlayerControls.FireDirection.performed += ctx => _lookpossition = ctx.ReadValue<Vector2>();
            _inputActions.PlayerControls.Shoot2.performed += _ => Shoot();
        }
    }

    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _spawnManager = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager>();

        if (_uiManager != null)
        {
            _uiManager.UpdatLives(lives);
        }

        /*if (_spawnManager != null)
        {
            _spawnManager.StarCorotines();
        }*/


        if (_gameManager.isCoopMode == false)
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        }

        hurtCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
        validateOnScreen();        
    }

    private void Shoot()
    {
        if (Time.time > _canFire)
        {
            if (canTripleShoot)
            {
                Instantiate(_triplelazerPrefab, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(_lazerPrefab, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
            }
            
            _canFire = Time.time + _fireRate;
        }

    }

    private void Moviment()
    {
        float h = 0.0f;
        float v = 0.0f;


        if (playerOne)
        {
            if (_movementInput.x != 0.0f || _movementInput.y != 0.0f)
            {
                h = _movementInput.x;
                v = _movementInput.y;
            }
        }

        if (playerTwo)
        {
            if (_lookpossition.x != 0.0f || _lookpossition.y != 0.0f)
            {
                h = _lookpossition.x;
                v = _lookpossition.y;
            }
        }

        Vector3 direction = new Vector3(h, v, 0);

        if (_speeBoost)
        {
            transform.Translate(direction * speed * 1.5f * Time.deltaTime);
        }
        else
        {
            transform.Translate(direction * speed * Time.deltaTime);
            
        }

    }

    private void validateOnScreen()
    {
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }
    }

    public void Damage()
    {
        if (_hasShield)
        {
            _hasShield = false;
            _shieldGameObject.SetActive(false);
            return;
        }

        hurtCount++;

        if (hurtCount == 1)
        {
            _fireHurt[0].SetActive(true);
        }
        else if (hurtCount == 2)
        {
            _fireHurt[1].SetActive(true);
        }

        lives--;

        if (_uiManager != null)
        {
            _uiManager.UpdatLives(lives);
        }

        if (lives < 1)
        {
            Instantiate(_explosion_prefab, transform.position, Quaternion.identity);
            _gameManager.gameOver = true;
            _uiManager.ShowTitleScreen();
            _uiManager.CheckBestScore();
            Destroy(this.gameObject);
        }
    }

    public void TripleShotPowerUpOn()
    {
        canTripleShoot = true;
        StartCoroutine(TripleShotDownRotine());
    }

    public void SpeedBoostOn()
    {
        _speeBoost = true;
        StartCoroutine(SpeedBoostDownRotine());
    }


    public void ShieldOn()
    {
        _hasShield = true;
        _shieldGameObject.SetActive(true);
        StartCoroutine(ShieldOnRotine());
    }

    IEnumerator ShieldOnRotine()
    {
        yield return new WaitForSeconds(5.0f);
        _hasShield = false;
        _shieldGameObject.SetActive(false);

    }


    IEnumerator TripleShotDownRotine()
    {
        yield return new WaitForSeconds(5.0f);
        canTripleShoot = false;
    }

    IEnumerator SpeedBoostDownRotine()
    {
        yield return new WaitForSeconds(5.0f);
        _speeBoost = false;
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Disable();
    }
}
