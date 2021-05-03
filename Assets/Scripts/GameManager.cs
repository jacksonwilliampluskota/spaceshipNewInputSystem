using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isCoopMode = false;
    public bool gameOver = true;

    private UIActionsInput _UIinputActions;
    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private GameObject _CoOpPlayer;

    private UIManager _uiManager;
    private SpawnManager _spawnManager;
    private GameObject _ThatDestroy;

    [SerializeField]
    private GameObject _pauseMenuPanel;

    private Animator _pauseAnimator;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _spawnManager = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager>();
        _pauseAnimator = GameObject.Find("Pause_Menu_Panel").GetComponent<Animator>();

        _pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    private void Awake()
    {
        _UIinputActions = new UIActionsInput();
        _UIinputActions.UI.Start.performed += _ => StartSpace();
        _UIinputActions.UI.End.performed += _ => EndGame();
        _UIinputActions.UI.Pause_Menu.performed += _ => PauseMenu();

    }

    private void PauseMenu()
    {
        _pauseMenuPanel.SetActive(true);
        _pauseAnimator.SetBool("IsPause", true);
        Time.timeScale = 0f;
    }

    public void ResumePlay()
    {
        _pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void StartSpace()
    {

        if (gameOver)
        {
            if (isCoopMode == false)
            {
                Instantiate(_player, Vector3.zero, Quaternion.identity);
            }
            else
            {
                if (_ThatDestroy != null)
                {
                    Destroy(_ThatDestroy);
                }
                _ThatDestroy = Instantiate(_CoOpPlayer, new Vector3(461f, 259.375f,0f), Quaternion.identity) as GameObject;
            }
            gameOver = false;
            _uiManager.HideTitelScreen();
            _spawnManager.StarCorotines();
        }

    }

    private void EndGame()
    {
        if (gameOver)
        {
            SceneManager.LoadScene("Main_menu");
        }
    }

    private void OnEnable()
    {
        _UIinputActions.Enable();
    }

    private void OnDisable()
    {
        _UIinputActions.Disable();
    }
}
