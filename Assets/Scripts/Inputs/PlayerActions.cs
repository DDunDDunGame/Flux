//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Inputs/PlayerActions.inputactions
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

public partial class @PlayerActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""None"",
            ""id"": ""5332e631-047c-4afe-a54e-7ae36b6b32f4"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""Shooting"",
            ""id"": ""84a04996-060e-4c67-aca5-ee7d2a936a66"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""0e67f896-54c2-4a9b-a218-8bf9802071d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7c20acde-244e-4af7-a682-c230f6351c33"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""93bb53b9-ad98-4ffb-8236-db06b6e9ba08"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef560cce-098f-49b0-936d-3f8910b3a30c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""dd5f01e4-ed53-4222-b0b0-a6319473ac63"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""944ca135-aaff-4a78-8832-dc6bccefc683"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4107fc7-0520-48ac-b6cc-054499439e75"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Run"",
            ""id"": ""02b14595-642a-492b-a6f2-5fed2c253280"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""26adaf51-af72-44fa-b3d0-00d6b548a36e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61ce844c-d7da-4100-be5d-d17015897cfa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Jump"",
            ""id"": ""8e371ffd-18a3-43af-9bbd-6987aa186a30"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3e3d2b17-44f0-4bd2-89c1-378d1abf1507"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""85d91a94-bed7-4f1a-aa1b-556616b48e8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""893bc079-8edc-47b4-9aa3-49ebbed67432"",
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
                    ""id"": ""a4bd302d-10db-4d71-938d-4609cf00c8db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""df523f3b-6435-4045-892e-a28e48c80634"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""05b79ca8-ff25-4701-a128-8d462fbb3ae3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""807d56d3-8ef1-4367-a92b-bc31c8571e50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8e74cb5a-5f8c-45a8-8c08-e94ad136224f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Orbit"",
            ""id"": ""de7c7d70-563e-4396-a4e4-a43f20da9a6d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7a1bf192-9a45-41d5-8681-7d0507cc5c98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""1991ce92-91cf-4c6e-a7ac-6280368e303b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b6eab3e-ee69-4d6a-b482-f76648db0bec"",
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
                    ""id"": ""547dcdaf-0d8b-4450-83cb-7a0491f78459"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Barrier"",
            ""id"": ""58c47e67-ad2b-4abb-a7b4-402d52dfcc62"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7cf92e0b-c0aa-4d82-b67b-f44a76e0eca0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""d81bd08c-f4a0-48eb-8517-51c24874bdba"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d28caae0-fdb2-45c9-88a5-3beee3222da3"",
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
                    ""id"": ""cde89c24-364c-41f2-bea1-441fd8fc0a74"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
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
        // None
        m_None = asset.FindActionMap("None", throwIfNotFound: true);
        // Shooting
        m_Shooting = asset.FindActionMap("Shooting", throwIfNotFound: true);
        m_Shooting_Up = m_Shooting.FindAction("Up", throwIfNotFound: true);
        m_Shooting_Shoot = m_Shooting.FindAction("Shoot", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Move = m_Mouse.FindAction("Move", throwIfNotFound: true);
        // Run
        m_Run = asset.FindActionMap("Run", throwIfNotFound: true);
        m_Run_Jump = m_Run.FindAction("Jump", throwIfNotFound: true);
        // Jump
        m_Jump = asset.FindActionMap("Jump", throwIfNotFound: true);
        m_Jump_Move = m_Jump.FindAction("Move", throwIfNotFound: true);
        m_Jump_Jump = m_Jump.FindAction("Jump", throwIfNotFound: true);
        // Orbit
        m_Orbit = asset.FindActionMap("Orbit", throwIfNotFound: true);
        m_Orbit_Move = m_Orbit.FindAction("Move", throwIfNotFound: true);
        // Barrier
        m_Barrier = asset.FindActionMap("Barrier", throwIfNotFound: true);
        m_Barrier_Move = m_Barrier.FindAction("Move", throwIfNotFound: true);
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

    // None
    private readonly InputActionMap m_None;
    private List<INoneActions> m_NoneActionsCallbackInterfaces = new List<INoneActions>();
    public struct NoneActions
    {
        private @PlayerActions m_Wrapper;
        public NoneActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_None; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NoneActions set) { return set.Get(); }
        public void AddCallbacks(INoneActions instance)
        {
            if (instance == null || m_Wrapper.m_NoneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NoneActionsCallbackInterfaces.Add(instance);
        }

        private void UnregisterCallbacks(INoneActions instance)
        {
        }

        public void RemoveCallbacks(INoneActions instance)
        {
            if (m_Wrapper.m_NoneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INoneActions instance)
        {
            foreach (var item in m_Wrapper.m_NoneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NoneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NoneActions @None => new NoneActions(this);

    // Shooting
    private readonly InputActionMap m_Shooting;
    private List<IShootingActions> m_ShootingActionsCallbackInterfaces = new List<IShootingActions>();
    private readonly InputAction m_Shooting_Up;
    private readonly InputAction m_Shooting_Shoot;
    public struct ShootingActions
    {
        private @PlayerActions m_Wrapper;
        public ShootingActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Shooting_Up;
        public InputAction @Shoot => m_Wrapper.m_Shooting_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Shooting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootingActions set) { return set.Get(); }
        public void AddCallbacks(IShootingActions instance)
        {
            if (instance == null || m_Wrapper.m_ShootingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShootingActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
        }

        private void UnregisterCallbacks(IShootingActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
        }

        public void RemoveCallbacks(IShootingActions instance)
        {
            if (m_Wrapper.m_ShootingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShootingActions instance)
        {
            foreach (var item in m_Wrapper.m_ShootingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShootingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShootingActions @Shooting => new ShootingActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private List<IMouseActions> m_MouseActionsCallbackInterfaces = new List<IMouseActions>();
    private readonly InputAction m_Mouse_Move;
    public struct MouseActions
    {
        private @PlayerActions m_Wrapper;
        public MouseActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mouse_Move;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void AddCallbacks(IMouseActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMouseActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Run
    private readonly InputActionMap m_Run;
    private List<IRunActions> m_RunActionsCallbackInterfaces = new List<IRunActions>();
    private readonly InputAction m_Run_Jump;
    public struct RunActions
    {
        private @PlayerActions m_Wrapper;
        public RunActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Run_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Run; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RunActions set) { return set.Get(); }
        public void AddCallbacks(IRunActions instance)
        {
            if (instance == null || m_Wrapper.m_RunActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RunActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IRunActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IRunActions instance)
        {
            if (m_Wrapper.m_RunActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRunActions instance)
        {
            foreach (var item in m_Wrapper.m_RunActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RunActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RunActions @Run => new RunActions(this);

    // Jump
    private readonly InputActionMap m_Jump;
    private List<IJumpActions> m_JumpActionsCallbackInterfaces = new List<IJumpActions>();
    private readonly InputAction m_Jump_Move;
    private readonly InputAction m_Jump_Jump;
    public struct JumpActions
    {
        private @PlayerActions m_Wrapper;
        public JumpActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Jump_Move;
        public InputAction @Jump => m_Wrapper.m_Jump_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Jump; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JumpActions set) { return set.Get(); }
        public void AddCallbacks(IJumpActions instance)
        {
            if (instance == null || m_Wrapper.m_JumpActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JumpActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IJumpActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IJumpActions instance)
        {
            if (m_Wrapper.m_JumpActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJumpActions instance)
        {
            foreach (var item in m_Wrapper.m_JumpActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JumpActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JumpActions @Jump => new JumpActions(this);

    // Orbit
    private readonly InputActionMap m_Orbit;
    private List<IOrbitActions> m_OrbitActionsCallbackInterfaces = new List<IOrbitActions>();
    private readonly InputAction m_Orbit_Move;
    public struct OrbitActions
    {
        private @PlayerActions m_Wrapper;
        public OrbitActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Orbit_Move;
        public InputActionMap Get() { return m_Wrapper.m_Orbit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OrbitActions set) { return set.Get(); }
        public void AddCallbacks(IOrbitActions instance)
        {
            if (instance == null || m_Wrapper.m_OrbitActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OrbitActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IOrbitActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IOrbitActions instance)
        {
            if (m_Wrapper.m_OrbitActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOrbitActions instance)
        {
            foreach (var item in m_Wrapper.m_OrbitActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OrbitActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OrbitActions @Orbit => new OrbitActions(this);

    // Barrier
    private readonly InputActionMap m_Barrier;
    private List<IBarrierActions> m_BarrierActionsCallbackInterfaces = new List<IBarrierActions>();
    private readonly InputAction m_Barrier_Move;
    public struct BarrierActions
    {
        private @PlayerActions m_Wrapper;
        public BarrierActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Barrier_Move;
        public InputActionMap Get() { return m_Wrapper.m_Barrier; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BarrierActions set) { return set.Get(); }
        public void AddCallbacks(IBarrierActions instance)
        {
            if (instance == null || m_Wrapper.m_BarrierActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BarrierActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IBarrierActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IBarrierActions instance)
        {
            if (m_Wrapper.m_BarrierActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBarrierActions instance)
        {
            foreach (var item in m_Wrapper.m_BarrierActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BarrierActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BarrierActions @Barrier => new BarrierActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface INoneActions
    {
    }
    public interface IShootingActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IRunActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IJumpActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IOrbitActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IBarrierActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
