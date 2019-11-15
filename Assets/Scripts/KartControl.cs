// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/KartControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KartControl : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @KartControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KartControl"",
    ""maps"": [
        {
            ""name"": ""Kart"",
            ""id"": ""4f9dc80a-078f-49d8-95ba-efd2db07a487"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Button"",
                    ""id"": ""09851743-2e59-4c99-8e9c-587fd0c38dbb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""23f22893-fdec-43ac-9d8d-209e2bfad686"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""b1314a32-2bfa-4c03-8612-82276b2ba7ec"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""afaa8e57-61f6-44d8-b399-d31838a5adf4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbdc000f-6564-4dcb-90a5-e155566a7416"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9be90c16-e6e6-4caf-9e59-7b73cf6de6e0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a622e83c-cbd5-42dc-bb67-28e82e0ed855"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec821ff1-ddd8-4fb8-8364-b783f5c7f7aa"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e27620d5-94dc-499e-9cbb-bc1a5d2bef0e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1aff6695-d688-4a64-b0c3-64cccc3ff8b2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""efdbd79f-a2b3-4bfb-8560-90c309597b19"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Kart
        m_Kart = asset.FindActionMap("Kart", throwIfNotFound: true);
        m_Kart_Drive = m_Kart.FindAction("Drive", throwIfNotFound: true);
        m_Kart_Drift = m_Kart.FindAction("Drift", throwIfNotFound: true);
        m_Kart_Turn = m_Kart.FindAction("Turn", throwIfNotFound: true);
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

    // Kart
    private readonly InputActionMap m_Kart;
    private IKartActions m_KartActionsCallbackInterface;
    private readonly InputAction m_Kart_Drive;
    private readonly InputAction m_Kart_Drift;
    private readonly InputAction m_Kart_Turn;
    public struct KartActions
    {
        private @KartControl m_Wrapper;
        public KartActions(@KartControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_Kart_Drive;
        public InputAction @Drift => m_Wrapper.m_Kart_Drift;
        public InputAction @Turn => m_Wrapper.m_Kart_Turn;
        public InputActionMap Get() { return m_Wrapper.m_Kart; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KartActions set) { return set.Get(); }
        public void SetCallbacks(IKartActions instance)
        {
            if (m_Wrapper.m_KartActionsCallbackInterface != null)
            {
                @Drive.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDrive;
                @Drive.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDrive;
                @Drive.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDrive;
                @Drift.started -= m_Wrapper.m_KartActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnDrift;
                @Turn.started -= m_Wrapper.m_KartActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_KartActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_KartActionsCallbackInterface.OnTurn;
            }
            m_Wrapper.m_KartActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Drive.started += instance.OnDrive;
                @Drive.performed += instance.OnDrive;
                @Drive.canceled += instance.OnDrive;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
            }
        }
    }
    public KartActions @Kart => new KartActions(this);
    public interface IKartActions
    {
        void OnDrive(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
}
