//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Managers/Game controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Gamecontrols: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Gamecontrols()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game controls"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""ffa2e929-8396-4b88-8164-9453e70dd077"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69ecfb0a-3839-4823-b509-b3ef05d4adb7"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1ed1274f-141f-49eb-b314-6d550fcc4e4e"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equip gun"",
                    ""type"": ""PassThrough"",
                    ""id"": ""62bf9cef-18b1-4eb8-925f-d0446d666a6b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UnEquip gun"",
                    ""type"": ""Button"",
                    ""id"": ""0af6810e-e7b5-47e6-8950-0eb1b6512ff2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ff15e2be-6963-4df1-a408-f79e95bdf1f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""6bdc770b-92af-420c-b918-34629cad7274"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99c1d91c-001a-4c93-a15b-7ac52824a945"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ef2a06ba-3891-4807-8df7-76a05b6142b1"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""be26341b-26c3-45b8-84a1-566beb7bb379"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""8b2bd613-b8d7-4a03-9e3a-0fcfb55777cd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""42cd7967-654d-4bd4-b8d8-aed920118e75"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""9455b934-6813-4263-b61c-5d1078850f61"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3d0dbc5f-22db-4a11-a578-5aa6bf9447a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed6bd335-f90d-4ec5-8c7f-ab2bb76d4dc6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7343184-3afd-43da-a338-962fed260a83"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnEquip gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37f74007-6d8f-40c5-b6be-6f3619ef96bc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4552fef2-d4e6-4f59-9f23-848e7997864f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""7cbe856d-b395-4e87-8abd-1cd697046f9b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""75dc24ac-da8e-46f9-bdba-0bab5f7e0249"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""547fbfd2-b58c-46bc-9c80-b7f33d13f541"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Permanent"",
            ""id"": ""e30a2eb0-0e11-4a6c-a5fc-dd11a9c7b75b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""ab543c80-2885-40f5-a44c-4a81a7431345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cc46296e-0cde-4277-9e50-576f1f23e6b5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RELOAD"",
            ""id"": ""19a1a48a-e1cc-4224-9661-9a40bec46097"",
            ""actions"": [
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""040113cb-dff5-47f9-a98d-ca5d703b956c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""654fc647-43e7-4aa4-8816-6abc136eebc6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Movement = m_InGame.FindAction("Movement", throwIfNotFound: true);
        m_InGame_Jump = m_InGame.FindAction("Jump", throwIfNotFound: true);
        m_InGame_Equipgun = m_InGame.FindAction("Equip gun", throwIfNotFound: true);
        m_InGame_UnEquipgun = m_InGame.FindAction("UnEquip gun", throwIfNotFound: true);
        m_InGame_Shoot = m_InGame.FindAction("Shoot", throwIfNotFound: true);
        m_InGame_Reload = m_InGame.FindAction("Reload", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
        // Permanent
        m_Permanent = asset.FindActionMap("Permanent", throwIfNotFound: true);
        m_Permanent_Newaction = m_Permanent.FindAction("New action", throwIfNotFound: true);
        // RELOAD
        m_RELOAD = asset.FindActionMap("RELOAD", throwIfNotFound: true);
        m_RELOAD_Reload = m_RELOAD.FindAction("Reload", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // InGame
    private readonly InputActionMap m_InGame;
    private List<IInGameActions> m_InGameActionsCallbackInterfaces = new List<IInGameActions>();
    private readonly InputAction m_InGame_Movement;
    private readonly InputAction m_InGame_Jump;
    private readonly InputAction m_InGame_Equipgun;
    private readonly InputAction m_InGame_UnEquipgun;
    private readonly InputAction m_InGame_Shoot;
    private readonly InputAction m_InGame_Reload;
    public struct InGameActions
    {
        private @Gamecontrols m_Wrapper;
        public InGameActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InGame_Movement;
        public InputAction @Jump => m_Wrapper.m_InGame_Jump;
        public InputAction @Equipgun => m_Wrapper.m_InGame_Equipgun;
        public InputAction @UnEquipgun => m_Wrapper.m_InGame_UnEquipgun;
        public InputAction @Shoot => m_Wrapper.m_InGame_Shoot;
        public InputAction @Reload => m_Wrapper.m_InGame_Reload;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void AddCallbacks(IInGameActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Equipgun.started += instance.OnEquipgun;
            @Equipgun.performed += instance.OnEquipgun;
            @Equipgun.canceled += instance.OnEquipgun;
            @UnEquipgun.started += instance.OnUnEquipgun;
            @UnEquipgun.performed += instance.OnUnEquipgun;
            @UnEquipgun.canceled += instance.OnUnEquipgun;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IInGameActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Equipgun.started -= instance.OnEquipgun;
            @Equipgun.performed -= instance.OnEquipgun;
            @Equipgun.canceled -= instance.OnEquipgun;
            @UnEquipgun.started -= instance.OnUnEquipgun;
            @UnEquipgun.performed -= instance.OnUnEquipgun;
            @UnEquipgun.canceled -= instance.OnUnEquipgun;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameActions @InGame => new InGameActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @Gamecontrols m_Wrapper;
        public UIActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);

    // Permanent
    private readonly InputActionMap m_Permanent;
    private List<IPermanentActions> m_PermanentActionsCallbackInterfaces = new List<IPermanentActions>();
    private readonly InputAction m_Permanent_Newaction;
    public struct PermanentActions
    {
        private @Gamecontrols m_Wrapper;
        public PermanentActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Permanent_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Permanent; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PermanentActions set) { return set.Get(); }
        public void AddCallbacks(IPermanentActions instance)
        {
            if (instance == null || m_Wrapper.m_PermanentActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PermanentActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IPermanentActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IPermanentActions instance)
        {
            if (m_Wrapper.m_PermanentActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPermanentActions instance)
        {
            foreach (var item in m_Wrapper.m_PermanentActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PermanentActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PermanentActions @Permanent => new PermanentActions(this);

    // RELOAD
    private readonly InputActionMap m_RELOAD;
    private List<IRELOADActions> m_RELOADActionsCallbackInterfaces = new List<IRELOADActions>();
    private readonly InputAction m_RELOAD_Reload;
    public struct RELOADActions
    {
        private @Gamecontrols m_Wrapper;
        public RELOADActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Reload => m_Wrapper.m_RELOAD_Reload;
        public InputActionMap Get() { return m_Wrapper.m_RELOAD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RELOADActions set) { return set.Get(); }
        public void AddCallbacks(IRELOADActions instance)
        {
            if (instance == null || m_Wrapper.m_RELOADActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RELOADActionsCallbackInterfaces.Add(instance);
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IRELOADActions instance)
        {
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IRELOADActions instance)
        {
            if (m_Wrapper.m_RELOADActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRELOADActions instance)
        {
            foreach (var item in m_Wrapper.m_RELOADActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RELOADActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RELOADActions @RELOAD => new RELOADActions(this);
    public interface IInGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnEquipgun(InputAction.CallbackContext context);
        void OnUnEquipgun(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IPermanentActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IRELOADActions
    {
        void OnReload(InputAction.CallbackContext context);
    }
}
