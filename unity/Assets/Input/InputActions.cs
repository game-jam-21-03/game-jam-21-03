// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b3c3f909-4f5e-43d5-9843-2f4bd3bed2f1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""42dbe1ca-9577-4602-a4fc-dde2bff4960d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""98578149-5067-4baf-9344-dfb227e2f41f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EchoPulse"",
                    ""type"": ""Button"",
                    ""id"": ""eb290d97-5906-48f6-989b-e23fee8e37c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""161f118e-1393-4dbb-b87b-6d223c240796"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IgnoreTraps"",
                    ""type"": ""Button"",
                    ""id"": ""ca79304a-74bb-4992-82d1-5a2ca12704da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IgnoreCollisions"",
                    ""type"": ""Button"",
                    ""id"": ""16fe9710-e6e6-4226-a5e4-7e753e588fcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportLevel1"",
                    ""type"": ""Button"",
                    ""id"": ""68e0c9e3-564b-4c36-a6ff-aebe590d6d20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportLevel2"",
                    ""type"": ""Button"",
                    ""id"": ""ebc150fd-9f4a-4ffb-bda7-f7c7980a55a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportLevel3"",
                    ""type"": ""Button"",
                    ""id"": ""aaeb3c83-654f-4fa6-8785-1bf332055142"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5c46ade7-2dd9-4d1f-903c-001d8d8b4d97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""918ef594-16e0-4eb3-849b-74f432c94da1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""20436b90-775c-46b2-837d-cc13cf7ae442"",
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
                    ""id"": ""c78478d0-a1d8-4c33-aad8-57807d0c36c8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""562a7a15-88fa-46ed-81e9-77aa84a0c419"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0183dc4d-7b6a-4c72-b087-38b07e14e033"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cabe8e89-d491-44be-994a-59cec5adcc5a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31e426cd-ccef-4695-bf98-1be40cd2ac6c"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""EchoPulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5fc712d-732a-4db3-b38b-dff24800fac7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""EchoPulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a95f49e5-63b0-40e3-9ac2-881bc88505e2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46914aa4-94f5-466b-851b-bd373d5ab8b0"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""IgnoreTraps"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9d4b94b-9bf0-4ea8-9494-4c12f47a4bc8"",
                    ""path"": ""<Keyboard>/f6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IgnoreCollisions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a8e912e-78c1-4714-8123-a102acd30996"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportLevel1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc926a6e-c449-4b1c-b08a-a55b9dba69f7"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportLevel2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcae4df3-87e2-48f3-8059-f7639857216a"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportLevel3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31823543-45c7-4faa-b528-705f8446ebaf"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_EchoPulse = m_Gameplay.FindAction("EchoPulse", throwIfNotFound: true);
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        m_Gameplay_IgnoreTraps = m_Gameplay.FindAction("IgnoreTraps", throwIfNotFound: true);
        m_Gameplay_IgnoreCollisions = m_Gameplay.FindAction("IgnoreCollisions", throwIfNotFound: true);
        m_Gameplay_TeleportLevel1 = m_Gameplay.FindAction("TeleportLevel1", throwIfNotFound: true);
        m_Gameplay_TeleportLevel2 = m_Gameplay.FindAction("TeleportLevel2", throwIfNotFound: true);
        m_Gameplay_TeleportLevel3 = m_Gameplay.FindAction("TeleportLevel3", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_EchoPulse;
    private readonly InputAction m_Gameplay_Interact;
    private readonly InputAction m_Gameplay_IgnoreTraps;
    private readonly InputAction m_Gameplay_IgnoreCollisions;
    private readonly InputAction m_Gameplay_TeleportLevel1;
    private readonly InputAction m_Gameplay_TeleportLevel2;
    private readonly InputAction m_Gameplay_TeleportLevel3;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @EchoPulse => m_Wrapper.m_Gameplay_EchoPulse;
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputAction @IgnoreTraps => m_Wrapper.m_Gameplay_IgnoreTraps;
        public InputAction @IgnoreCollisions => m_Wrapper.m_Gameplay_IgnoreCollisions;
        public InputAction @TeleportLevel1 => m_Wrapper.m_Gameplay_TeleportLevel1;
        public InputAction @TeleportLevel2 => m_Wrapper.m_Gameplay_TeleportLevel2;
        public InputAction @TeleportLevel3 => m_Wrapper.m_Gameplay_TeleportLevel3;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @EchoPulse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEchoPulse;
                @EchoPulse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEchoPulse;
                @EchoPulse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEchoPulse;
                @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @IgnoreTraps.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreTraps;
                @IgnoreTraps.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreTraps;
                @IgnoreTraps.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreTraps;
                @IgnoreCollisions.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreCollisions;
                @IgnoreCollisions.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreCollisions;
                @IgnoreCollisions.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIgnoreCollisions;
                @TeleportLevel1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel1;
                @TeleportLevel1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel1;
                @TeleportLevel1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel1;
                @TeleportLevel2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel2;
                @TeleportLevel2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel2;
                @TeleportLevel2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel2;
                @TeleportLevel3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel3;
                @TeleportLevel3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel3;
                @TeleportLevel3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTeleportLevel3;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @EchoPulse.started += instance.OnEchoPulse;
                @EchoPulse.performed += instance.OnEchoPulse;
                @EchoPulse.canceled += instance.OnEchoPulse;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @IgnoreTraps.started += instance.OnIgnoreTraps;
                @IgnoreTraps.performed += instance.OnIgnoreTraps;
                @IgnoreTraps.canceled += instance.OnIgnoreTraps;
                @IgnoreCollisions.started += instance.OnIgnoreCollisions;
                @IgnoreCollisions.performed += instance.OnIgnoreCollisions;
                @IgnoreCollisions.canceled += instance.OnIgnoreCollisions;
                @TeleportLevel1.started += instance.OnTeleportLevel1;
                @TeleportLevel1.performed += instance.OnTeleportLevel1;
                @TeleportLevel1.canceled += instance.OnTeleportLevel1;
                @TeleportLevel2.started += instance.OnTeleportLevel2;
                @TeleportLevel2.performed += instance.OnTeleportLevel2;
                @TeleportLevel2.canceled += instance.OnTeleportLevel2;
                @TeleportLevel3.started += instance.OnTeleportLevel3;
                @TeleportLevel3.performed += instance.OnTeleportLevel3;
                @TeleportLevel3.canceled += instance.OnTeleportLevel3;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnEchoPulse(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnIgnoreTraps(InputAction.CallbackContext context);
        void OnIgnoreCollisions(InputAction.CallbackContext context);
        void OnTeleportLevel1(InputAction.CallbackContext context);
        void OnTeleportLevel2(InputAction.CallbackContext context);
        void OnTeleportLevel3(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
