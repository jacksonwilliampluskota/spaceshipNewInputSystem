using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator _anim;
    private PlayerInputActions _inputActions;
    // Start is called before the first frame update

    private Player _player;

    private void Awake()
    {

        _player = GetComponent<Player>();

        _inputActions = new PlayerInputActions();

        if (_player.playerOne)
        {
            _inputActions.PlayerControls.AnimationMovieLeft.performed += _ => MoveToLeft();
            _inputActions.PlayerControls.AnimationMovieRight.performed += _ => MoveToRight();
            _inputActions.PlayerControls.AnimationMovieLeft.canceled += _ => StopAnimation();
            _inputActions.PlayerControls.AnimationMovieRight.canceled += _ => StopAnimation();
        }
        else if(_player.playerTwo)
        {
            _inputActions.PlayerControls.AnimationMovieLeft2.performed += _ => MoveToLeft();
            _inputActions.PlayerControls.AnimationMovieRight2.performed += _ => MoveToRight();
            _inputActions.PlayerControls.AnimationMovieLeft2.canceled += _ => StopAnimation();
            _inputActions.PlayerControls.AnimationMovieRight2.canceled += _ => StopAnimation();
        }

    }
    void Start()
    {

        _anim = GetComponent<Animator>();
        
    }

    void MoveToLeft()
    {
        _anim.SetBool("Turn_Left", true);
        _anim.SetBool("Turn_Right", false);
    }

    void MoveToRight()
    {
        _anim.SetBool("Turn_Left", false);
        _anim.SetBool("Turn_Right", true);
    }

    void StopAnimation()
    {
        _anim.SetBool("Turn_Left", false);
        _anim.SetBool("Turn_Right", false);
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
