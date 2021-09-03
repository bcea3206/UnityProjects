// GENERATED AUTOMATICALLY FROM 'Assets/input/1st person controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @_1stpersoncontrols : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @_1stpersoncontrols()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""1st person controls"",
    ""maps"": [
        {
            ""name"": ""gameplay controls"",
            ""id"": ""b09022b5-8266-4ccc-b50c-0ea3e9e285a6"",
            ""actions"": [
                {
                    ""name"": ""camera look"",
                    ""type"": ""Value"",
                    ""id"": ""e36142a4-c29a-4a76-9ee5-5aa3d5ea369b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""playerMove"",
                    ""type"": ""Value"",
                    ""id"": ""2e423080-f78f-41a2-a1d0-294635030c76"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce797b61-0c74-45c1-99a1-27fdff3cdfc2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard & mouse"",
                    ""action"": ""camera look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97ef81c2-79b3-4ddd-b93a-bdedb7c92879"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""camera look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bb4d0276-b44a-4411-9e12-516a1b9e2acb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""playerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""041e51d4-e90b-4800-b474-f63f41f5ab72"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""playerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae7768be-33b8-422c-a0c4-1f9c6b3aa07d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""playerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1076da7-7944-470a-a0bf-1b1520fb6d03"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""playerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b95d73e1-dc18-4170-a4ab-53f71fbae381"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""playerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard and mouse"",
            ""bindingGroup"": ""keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // gameplay controls
        m_gameplaycontrols = asset.FindActionMap("gameplay controls", throwIfNotFound: true);
        m_gameplaycontrols_cameralook = m_gameplaycontrols.FindAction("camera look", throwIfNotFound: true);
        m_gameplaycontrols_playerMove = m_gameplaycontrols.FindAction("playerMove", throwIfNotFound: true);
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

    // gameplay controls
    private readonly InputActionMap m_gameplaycontrols;
    private IGameplaycontrolsActions m_GameplaycontrolsActionsCallbackInterface;
    private readonly InputAction m_gameplaycontrols_cameralook;
    private readonly InputAction m_gameplaycontrols_playerMove;
    public struct GameplaycontrolsActions
    {
        private @_1stpersoncontrols m_Wrapper;
        public GameplaycontrolsActions(@_1stpersoncontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @cameralook => m_Wrapper.m_gameplaycontrols_cameralook;
        public InputAction @playerMove => m_Wrapper.m_gameplaycontrols_playerMove;
        public InputActionMap Get() { return m_Wrapper.m_gameplaycontrols; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplaycontrolsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplaycontrolsActions instance)
        {
            if (m_Wrapper.m_GameplaycontrolsActionsCallbackInterface != null)
            {
                @cameralook.started -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnCameralook;
                @cameralook.performed -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnCameralook;
                @cameralook.canceled -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnCameralook;
                @playerMove.started -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnPlayerMove;
                @playerMove.performed -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnPlayerMove;
                @playerMove.canceled -= m_Wrapper.m_GameplaycontrolsActionsCallbackInterface.OnPlayerMove;
            }
            m_Wrapper.m_GameplaycontrolsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @cameralook.started += instance.OnCameralook;
                @cameralook.performed += instance.OnCameralook;
                @cameralook.canceled += instance.OnCameralook;
                @playerMove.started += instance.OnPlayerMove;
                @playerMove.performed += instance.OnPlayerMove;
                @playerMove.canceled += instance.OnPlayerMove;
            }
        }
    }
    public GameplaycontrolsActions @gameplaycontrols => new GameplaycontrolsActions(this);
    private int m_keyboardandmouseSchemeIndex = -1;
    public InputControlScheme keyboardandmouseScheme
    {
        get
        {
            if (m_keyboardandmouseSchemeIndex == -1) m_keyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("keyboard and mouse");
            return asset.controlSchemes[m_keyboardandmouseSchemeIndex];
        }
    }
    public interface IGameplaycontrolsActions
    {
        void OnCameralook(InputAction.CallbackContext context);
        void OnPlayerMove(InputAction.CallbackContext context);
    }
}
