//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Content/Scripts/Inputs/PlayerInputSystem.inputactions
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

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Rotate"",
            ""id"": ""8b445174-f6d1-4a54-ba59-537134e83e28"",
            ""actions"": [
                {
                    ""name"": ""RotationDir"",
                    ""type"": ""Value"",
                    ""id"": ""20c23aac-ef15-4602-a15c-da2ae7705a4b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""HorizontalDir"",
                    ""id"": ""5065049f-40ba-4803-a38f-d2fc8920dd4d"",
                    ""path"": ""1DAxis(maxValue=180)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""93a17465-622c-411a-a0fe-526ccc7143e4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""764d7051-4b1a-4ba5-b1bc-5fe8d5c88f4c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VerticalDir"",
                    ""id"": ""c788024c-0ab5-4011-8efa-2acc30fabe13"",
                    ""path"": ""1DAxis(minValue=-90,maxValue=90)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8374f61e-15f0-4803-be67-1893cd5b5d94"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""808485c6-c5f9-4de5-bb2a-b8f68eb36dc5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""QuitGame"",
            ""id"": ""c5216bab-aaa6-4502-838b-cf76eb911b10"",
            ""actions"": [
                {
                    ""name"": ""QuitGameBtnPressed"",
                    ""type"": ""Button"",
                    ""id"": ""9739b58c-f16d-4aae-8500-bf4151a3284a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c7bfe26-1fc2-44d9-a38b-242cf02c0b9f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitGameBtnPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rotate
        m_Rotate = asset.FindActionMap("Rotate", throwIfNotFound: true);
        m_Rotate_RotationDir = m_Rotate.FindAction("RotationDir", throwIfNotFound: true);
        // QuitGame
        m_QuitGame = asset.FindActionMap("QuitGame", throwIfNotFound: true);
        m_QuitGame_QuitGameBtnPressed = m_QuitGame.FindAction("QuitGameBtnPressed", throwIfNotFound: true);
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

    // Rotate
    private readonly InputActionMap m_Rotate;
    private IRotateActions m_RotateActionsCallbackInterface;
    private readonly InputAction m_Rotate_RotationDir;
    public struct RotateActions
    {
        private @PlayerInputs m_Wrapper;
        public RotateActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationDir => m_Wrapper.m_Rotate_RotationDir;
        public InputActionMap Get() { return m_Wrapper.m_Rotate; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotateActions set) { return set.Get(); }
        public void SetCallbacks(IRotateActions instance)
        {
            if (m_Wrapper.m_RotateActionsCallbackInterface != null)
            {
                @RotationDir.started -= m_Wrapper.m_RotateActionsCallbackInterface.OnRotationDir;
                @RotationDir.performed -= m_Wrapper.m_RotateActionsCallbackInterface.OnRotationDir;
                @RotationDir.canceled -= m_Wrapper.m_RotateActionsCallbackInterface.OnRotationDir;
            }
            m_Wrapper.m_RotateActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotationDir.started += instance.OnRotationDir;
                @RotationDir.performed += instance.OnRotationDir;
                @RotationDir.canceled += instance.OnRotationDir;
            }
        }
    }
    public RotateActions @Rotate => new RotateActions(this);

    // QuitGame
    private readonly InputActionMap m_QuitGame;
    private IQuitGameActions m_QuitGameActionsCallbackInterface;
    private readonly InputAction m_QuitGame_QuitGameBtnPressed;
    public struct QuitGameActions
    {
        private @PlayerInputs m_Wrapper;
        public QuitGameActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @QuitGameBtnPressed => m_Wrapper.m_QuitGame_QuitGameBtnPressed;
        public InputActionMap Get() { return m_Wrapper.m_QuitGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuitGameActions set) { return set.Get(); }
        public void SetCallbacks(IQuitGameActions instance)
        {
            if (m_Wrapper.m_QuitGameActionsCallbackInterface != null)
            {
                @QuitGameBtnPressed.started -= m_Wrapper.m_QuitGameActionsCallbackInterface.OnQuitGameBtnPressed;
                @QuitGameBtnPressed.performed -= m_Wrapper.m_QuitGameActionsCallbackInterface.OnQuitGameBtnPressed;
                @QuitGameBtnPressed.canceled -= m_Wrapper.m_QuitGameActionsCallbackInterface.OnQuitGameBtnPressed;
            }
            m_Wrapper.m_QuitGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @QuitGameBtnPressed.started += instance.OnQuitGameBtnPressed;
                @QuitGameBtnPressed.performed += instance.OnQuitGameBtnPressed;
                @QuitGameBtnPressed.canceled += instance.OnQuitGameBtnPressed;
            }
        }
    }
    public QuitGameActions @QuitGame => new QuitGameActions(this);
    public interface IRotateActions
    {
        void OnRotationDir(InputAction.CallbackContext context);
    }
    public interface IQuitGameActions
    {
        void OnQuitGameBtnPressed(InputAction.CallbackContext context);
    }
}
