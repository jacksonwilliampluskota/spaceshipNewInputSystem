// GENERATED AUTOMATICALLY FROM 'Assets/UIActionsInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UIActionsInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIActionsInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIActionsInput"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""0ffc1379-2b97-49c4-a699-69d324496fbf"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""8c938ce0-d270-40b3-abdc-87ead6f67e8d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""End"",
                    ""type"": ""Button"",
                    ""id"": ""257befd3-0b97-4477-a2ac-b58249710f0a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause_Menu"",
                    ""type"": ""Button"",
                    ""id"": ""8718b367-fb5a-408b-900f-acb78d8d03f4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1dec1efe-4510-4985-bd2d-2654a6f642db"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90f9fff4-55ba-4e40-8e71-eedc3a8cfec5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbc3f3c4-a00b-40bb-8003-4fd8d807a101"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f4b6706-756f-4de6-b0cf-823893d5175a"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
        m_UI_End = m_UI.FindAction("End", throwIfNotFound: true);
        m_UI_Pause_Menu = m_UI.FindAction("Pause_Menu", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Start;
    private readonly InputAction m_UI_End;
    private readonly InputAction m_UI_Pause_Menu;
    public struct UIActions
    {
        private @UIActionsInput m_Wrapper;
        public UIActions(@UIActionsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputAction @End => m_Wrapper.m_UI_End;
        public InputAction @Pause_Menu => m_Wrapper.m_UI_Pause_Menu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @End.started -= m_Wrapper.m_UIActionsCallbackInterface.OnEnd;
                @End.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnEnd;
                @End.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnEnd;
                @Pause_Menu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause_Menu;
                @Pause_Menu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause_Menu;
                @Pause_Menu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause_Menu;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @End.started += instance.OnEnd;
                @End.performed += instance.OnEnd;
                @End.canceled += instance.OnEnd;
                @Pause_Menu.started += instance.OnPause_Menu;
                @Pause_Menu.performed += instance.OnPause_Menu;
                @Pause_Menu.canceled += instance.OnPause_Menu;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnStart(InputAction.CallbackContext context);
        void OnEnd(InputAction.CallbackContext context);
        void OnPause_Menu(InputAction.CallbackContext context);
    }
}
