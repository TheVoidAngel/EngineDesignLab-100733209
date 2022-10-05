//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/_Scripts/PlayerCharAction.inputactions
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

public partial class @PlayerCharAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCharAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCharAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3491e70a-ff9e-4130-ad05-00856c4a1457"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""26098965-8254-4da3-b50c-788f14710ce1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c8d4df7e-de5b-4f4e-9928-87fd51c06bfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a35fda58-2f4a-4d21-991f-e8c1d7c7ff9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""066e322b-3b53-40d4-8140-6ccfe9bd83aa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""34e21079-f41f-4211-b3d9-7bf659e70c17"",
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
                    ""id"": ""5db9c0b4-33c2-43ff-b82e-cea53abdbebf"",
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
                    ""id"": ""61c6f61e-9622-4489-9e72-e9abef627c33"",
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
                    ""id"": ""3bb2827b-6342-4688-a177-00684bbd141b"",
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
                    ""id"": ""58b8f440-f377-4dc6-9c1b-1216cc3e213d"",
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
                    ""id"": ""e3d619db-9b29-4ef8-ba15-8bb763ed2df0"",
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
                    ""id"": ""d9a1496c-eac4-4c8a-bb2f-505b2d71c2a6"",
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
                    ""id"": ""9ea3cdd2-1023-4f8a-9c3f-bdfd9e5b5c61"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Editor"",
            ""id"": ""7927d78f-6421-4d18-97fb-9445903fb833"",
            ""actions"": [
                {
                    ""name"": ""EnableEditor"",
                    ""type"": ""Button"",
                    ""id"": ""48f7415d-69e0-464d-accb-a1f78eae3335"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Additem1"",
                    ""type"": ""Button"",
                    ""id"": ""93eb8c1e-8c80-4128-8187-1274d85f7ac2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Additem2"",
                    ""type"": ""Button"",
                    ""id"": ""123674a7-1039-4e05-9164-9d33e4784756"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dropitem"",
                    ""type"": ""Button"",
                    ""id"": ""42142165-7890-4c2c-98bb-f4194bdfa6b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""1dff91ab-af7a-4ff3-baf6-cae857b6cf7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ddba8077-e13a-488d-a3a6-510c213ea308"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableEditor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""524c8722-8f72-4415-8f25-d04a6c0a293f"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Additem1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fe9c34c-b73b-4ad4-916b-300c232ecd33"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Additem2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80bd250a-2c2c-4ad6-a831-7ffa842ca979"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dropitem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fa8dfd2-0540-4c0e-ad34-a492cfc6c8d4"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        // Editor
        m_Editor = asset.FindActionMap("Editor", throwIfNotFound: true);
        m_Editor_EnableEditor = m_Editor.FindAction("EnableEditor", throwIfNotFound: true);
        m_Editor_Additem1 = m_Editor.FindAction("Additem1", throwIfNotFound: true);
        m_Editor_Additem2 = m_Editor.FindAction("Additem2", throwIfNotFound: true);
        m_Editor_Dropitem = m_Editor.FindAction("Dropitem", throwIfNotFound: true);
        m_Editor_Save = m_Editor.FindAction("Save", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Look;
    public struct PlayerActions
    {
        private @PlayerCharAction m_Wrapper;
        public PlayerActions(@PlayerCharAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Editor
    private readonly InputActionMap m_Editor;
    private IEditorActions m_EditorActionsCallbackInterface;
    private readonly InputAction m_Editor_EnableEditor;
    private readonly InputAction m_Editor_Additem1;
    private readonly InputAction m_Editor_Additem2;
    private readonly InputAction m_Editor_Dropitem;
    private readonly InputAction m_Editor_Save;
    public struct EditorActions
    {
        private @PlayerCharAction m_Wrapper;
        public EditorActions(@PlayerCharAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnableEditor => m_Wrapper.m_Editor_EnableEditor;
        public InputAction @Additem1 => m_Wrapper.m_Editor_Additem1;
        public InputAction @Additem2 => m_Wrapper.m_Editor_Additem2;
        public InputAction @Dropitem => m_Wrapper.m_Editor_Dropitem;
        public InputAction @Save => m_Wrapper.m_Editor_Save;
        public InputActionMap Get() { return m_Wrapper.m_Editor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorActions set) { return set.Get(); }
        public void SetCallbacks(IEditorActions instance)
        {
            if (m_Wrapper.m_EditorActionsCallbackInterface != null)
            {
                @EnableEditor.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @EnableEditor.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @EnableEditor.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnEnableEditor;
                @Additem1.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem1;
                @Additem1.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem1;
                @Additem1.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem1;
                @Additem2.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem2;
                @Additem2.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem2;
                @Additem2.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAdditem2;
                @Dropitem.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropitem;
                @Dropitem.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropitem;
                @Dropitem.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropitem;
                @Save.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
            }
            m_Wrapper.m_EditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnableEditor.started += instance.OnEnableEditor;
                @EnableEditor.performed += instance.OnEnableEditor;
                @EnableEditor.canceled += instance.OnEnableEditor;
                @Additem1.started += instance.OnAdditem1;
                @Additem1.performed += instance.OnAdditem1;
                @Additem1.canceled += instance.OnAdditem1;
                @Additem2.started += instance.OnAdditem2;
                @Additem2.performed += instance.OnAdditem2;
                @Additem2.canceled += instance.OnAdditem2;
                @Dropitem.started += instance.OnDropitem;
                @Dropitem.performed += instance.OnDropitem;
                @Dropitem.canceled += instance.OnDropitem;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
            }
        }
    }
    public EditorActions @Editor => new EditorActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IEditorActions
    {
        void OnEnableEditor(InputAction.CallbackContext context);
        void OnAdditem1(InputAction.CallbackContext context);
        void OnAdditem2(InputAction.CallbackContext context);
        void OnDropitem(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
    }
}
