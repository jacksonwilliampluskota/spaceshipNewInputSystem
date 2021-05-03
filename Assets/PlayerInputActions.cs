// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""aff046ed-987f-4826-a7b6-ce548d5b5a6f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""632a3941-0d84-41e7-bc75-8307862d1a14"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3bd05f2f-ea6f-4253-83d9-6284afdc1940"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""dfb1de7c-1094-4805-8b08-593dbef724a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieUP"",
                    ""type"": ""Button"",
                    ""id"": ""45a9f099-b832-4276-9b59-1d37080ffa0d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieDown"",
                    ""type"": ""Button"",
                    ""id"": ""20062bfb-b9fa-4e00-bca3-048785b5ddb4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieLeft"",
                    ""type"": ""Button"",
                    ""id"": ""f9e7bbad-86b0-4878-8c39-7942f24ebdcb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieRight"",
                    ""type"": ""Button"",
                    ""id"": ""13ad0052-a654-4104-8e9b-8de5400f6e9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot2"",
                    ""type"": ""Button"",
                    ""id"": ""7e801fd7-71cb-4060-a593-ac6ee0d0e95e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieUP2"",
                    ""type"": ""Button"",
                    ""id"": ""4e6c2045-34dd-4bc2-a04a-943d23f524c3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieDown2"",
                    ""type"": ""Button"",
                    ""id"": ""b35a99f8-cbf6-4f1a-a225-9b38c6db9c87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieLeft2"",
                    ""type"": ""Button"",
                    ""id"": ""56e58be7-1079-4e56-af05-b28baf4741ef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnimationMovieRight2"",
                    ""type"": ""Button"",
                    ""id"": ""e46fbdd3-d68a-4ea9-af8a-fde7eec6783a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""50c48636-2ed7-42c8-b554-7b358cf493c9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""75ff1560-3cc8-4e2b-8a19-a4741ea80c54"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40dbe087-a536-440e-9257-37beb0898c2f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2b4e52fa-5a11-4e06-af10-b758bf8ab03c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""224983e4-aaab-4701-b4e8-3ce2a997fe06"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61a3775e-2c08-42df-8c04-f9f6c9143628"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ef7ee3cb-e537-433a-bcf4-96f2c52f78cc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""fd30cd53-8ac7-40f2-bad6-53f980e1f656"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""979fef37-03f4-41c2-9340-7e7b01b3ba1e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9d8265a2-02c8-4e4b-8c44-46a1bedf6b14"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a1191e6f-4e83-4791-99f1-d0a738ddb73f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eaeff5a2-fe0d-45fe-9e46-075738f28b64"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""36a336e1-4fe4-4593-bdc1-e12d1c017c00"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79531e80-ea38-4ee8-abcf-dc86f687256d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ed3ab4e-c1ec-4006-a4f8-dd0cebd94a13"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieUP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08f72b35-9626-4ab5-87dc-4e255142aac6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""717745ad-9c82-43c9-8f51-fdcb645b4bc6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c382d9-942d-48f4-88aa-e40855586f15"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8b0b00f-5f9d-4140-bcad-60a208e47fc9"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46e2c6b2-df69-4486-8187-54c1d3e36b08"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieUP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""063e12df-f1c9-48d2-ac58-af2254523ad7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieDown2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea723fdd-bca0-4545-b2b8-6cd080f69171"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieLeft2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9b6ed64-9667-4906-8306-5ae690a0cb36"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnimationMovieRight2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_FireDirection = m_PlayerControls.FindAction("Fire Direction", throwIfNotFound: true);
        m_PlayerControls_Shoot = m_PlayerControls.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieUP = m_PlayerControls.FindAction("AnimationMovieUP", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieDown = m_PlayerControls.FindAction("AnimationMovieDown", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieLeft = m_PlayerControls.FindAction("AnimationMovieLeft", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieRight = m_PlayerControls.FindAction("AnimationMovieRight", throwIfNotFound: true);
        m_PlayerControls_Shoot2 = m_PlayerControls.FindAction("Shoot2", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieUP2 = m_PlayerControls.FindAction("AnimationMovieUP2", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieDown2 = m_PlayerControls.FindAction("AnimationMovieDown2", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieLeft2 = m_PlayerControls.FindAction("AnimationMovieLeft2", throwIfNotFound: true);
        m_PlayerControls_AnimationMovieRight2 = m_PlayerControls.FindAction("AnimationMovieRight2", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_FireDirection;
    private readonly InputAction m_PlayerControls_Shoot;
    private readonly InputAction m_PlayerControls_AnimationMovieUP;
    private readonly InputAction m_PlayerControls_AnimationMovieDown;
    private readonly InputAction m_PlayerControls_AnimationMovieLeft;
    private readonly InputAction m_PlayerControls_AnimationMovieRight;
    private readonly InputAction m_PlayerControls_Shoot2;
    private readonly InputAction m_PlayerControls_AnimationMovieUP2;
    private readonly InputAction m_PlayerControls_AnimationMovieDown2;
    private readonly InputAction m_PlayerControls_AnimationMovieLeft2;
    private readonly InputAction m_PlayerControls_AnimationMovieRight2;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @FireDirection => m_Wrapper.m_PlayerControls_FireDirection;
        public InputAction @Shoot => m_Wrapper.m_PlayerControls_Shoot;
        public InputAction @AnimationMovieUP => m_Wrapper.m_PlayerControls_AnimationMovieUP;
        public InputAction @AnimationMovieDown => m_Wrapper.m_PlayerControls_AnimationMovieDown;
        public InputAction @AnimationMovieLeft => m_Wrapper.m_PlayerControls_AnimationMovieLeft;
        public InputAction @AnimationMovieRight => m_Wrapper.m_PlayerControls_AnimationMovieRight;
        public InputAction @Shoot2 => m_Wrapper.m_PlayerControls_Shoot2;
        public InputAction @AnimationMovieUP2 => m_Wrapper.m_PlayerControls_AnimationMovieUP2;
        public InputAction @AnimationMovieDown2 => m_Wrapper.m_PlayerControls_AnimationMovieDown2;
        public InputAction @AnimationMovieLeft2 => m_Wrapper.m_PlayerControls_AnimationMovieLeft2;
        public InputAction @AnimationMovieRight2 => m_Wrapper.m_PlayerControls_AnimationMovieRight2;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @FireDirection.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                @FireDirection.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                @FireDirection.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFireDirection;
                @Shoot.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot;
                @AnimationMovieUP.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP;
                @AnimationMovieUP.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP;
                @AnimationMovieUP.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP;
                @AnimationMovieDown.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown;
                @AnimationMovieDown.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown;
                @AnimationMovieDown.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown;
                @AnimationMovieLeft.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft;
                @AnimationMovieLeft.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft;
                @AnimationMovieLeft.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft;
                @AnimationMovieRight.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight;
                @AnimationMovieRight.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight;
                @AnimationMovieRight.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight;
                @Shoot2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot2;
                @Shoot2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot2;
                @Shoot2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnShoot2;
                @AnimationMovieUP2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP2;
                @AnimationMovieUP2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP2;
                @AnimationMovieUP2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieUP2;
                @AnimationMovieDown2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown2;
                @AnimationMovieDown2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown2;
                @AnimationMovieDown2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieDown2;
                @AnimationMovieLeft2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft2;
                @AnimationMovieLeft2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft2;
                @AnimationMovieLeft2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieLeft2;
                @AnimationMovieRight2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight2;
                @AnimationMovieRight2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight2;
                @AnimationMovieRight2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAnimationMovieRight2;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @FireDirection.started += instance.OnFireDirection;
                @FireDirection.performed += instance.OnFireDirection;
                @FireDirection.canceled += instance.OnFireDirection;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @AnimationMovieUP.started += instance.OnAnimationMovieUP;
                @AnimationMovieUP.performed += instance.OnAnimationMovieUP;
                @AnimationMovieUP.canceled += instance.OnAnimationMovieUP;
                @AnimationMovieDown.started += instance.OnAnimationMovieDown;
                @AnimationMovieDown.performed += instance.OnAnimationMovieDown;
                @AnimationMovieDown.canceled += instance.OnAnimationMovieDown;
                @AnimationMovieLeft.started += instance.OnAnimationMovieLeft;
                @AnimationMovieLeft.performed += instance.OnAnimationMovieLeft;
                @AnimationMovieLeft.canceled += instance.OnAnimationMovieLeft;
                @AnimationMovieRight.started += instance.OnAnimationMovieRight;
                @AnimationMovieRight.performed += instance.OnAnimationMovieRight;
                @AnimationMovieRight.canceled += instance.OnAnimationMovieRight;
                @Shoot2.started += instance.OnShoot2;
                @Shoot2.performed += instance.OnShoot2;
                @Shoot2.canceled += instance.OnShoot2;
                @AnimationMovieUP2.started += instance.OnAnimationMovieUP2;
                @AnimationMovieUP2.performed += instance.OnAnimationMovieUP2;
                @AnimationMovieUP2.canceled += instance.OnAnimationMovieUP2;
                @AnimationMovieDown2.started += instance.OnAnimationMovieDown2;
                @AnimationMovieDown2.performed += instance.OnAnimationMovieDown2;
                @AnimationMovieDown2.canceled += instance.OnAnimationMovieDown2;
                @AnimationMovieLeft2.started += instance.OnAnimationMovieLeft2;
                @AnimationMovieLeft2.performed += instance.OnAnimationMovieLeft2;
                @AnimationMovieLeft2.canceled += instance.OnAnimationMovieLeft2;
                @AnimationMovieRight2.started += instance.OnAnimationMovieRight2;
                @AnimationMovieRight2.performed += instance.OnAnimationMovieRight2;
                @AnimationMovieRight2.canceled += instance.OnAnimationMovieRight2;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFireDirection(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAnimationMovieUP(InputAction.CallbackContext context);
        void OnAnimationMovieDown(InputAction.CallbackContext context);
        void OnAnimationMovieLeft(InputAction.CallbackContext context);
        void OnAnimationMovieRight(InputAction.CallbackContext context);
        void OnShoot2(InputAction.CallbackContext context);
        void OnAnimationMovieUP2(InputAction.CallbackContext context);
        void OnAnimationMovieDown2(InputAction.CallbackContext context);
        void OnAnimationMovieLeft2(InputAction.CallbackContext context);
        void OnAnimationMovieRight2(InputAction.CallbackContext context);
    }
}
