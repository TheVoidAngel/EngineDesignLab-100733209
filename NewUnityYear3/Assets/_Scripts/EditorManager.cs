using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    public static EditorManager instance;

    PlayerCharAction inputAction;

    public Camera mainCam;
    public Camera editorCam;

    public GameObject prefab1;
    public GameObject prefab2;

    public GameObject item;

    public bool editorMode = false;
    public bool instatiated = false;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    ICommand command;

    UIManager ui;

    // Start is called before the first frame update
    void Awake()
    {
<<<<<<< Updated upstream
        inputAction = new PlayerCharAction();
=======
        if(instance == null)
        {
            instance = this;
        }

        inputAction = PlayerInputController.controller.inputAction;
>>>>>>> Stashed changes

        inputAction.Editor.EnableEditor.performed += cntxt => SwitchCamera();

        inputAction.Editor.Additem1.performed += cntxt => AddItem(1);
        inputAction.Editor.Additem2.performed += cntxt => AddItem(2);
        inputAction.Editor.Dropitem.performed += cntxt => DropItem();
        mainCam.enabled = true;
        editorCam.enabled = false;

        ui = GetComponent<UIManager>();
    }

    private void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;

        ui.ToggleEditorUI();
    }

    private void AddItem (int itemId)
    {
        if(editorMode && !instatiated)
        {
            switch (itemId)
            {
                case 1:
                    item = Instantiate(prefab1);
                    break;
                case 2:
                    item= Instantiate(prefab2);
                    break;
                default:
                    break;
            }
            instatiated = true;
        }
    }

    private void DropItem()
    {

<<<<<<< Updated upstream
=======
            command = new PlaceItemCommand(item.transform.position, item.transform);
            CommandInvoker.AddCommand(command);

            instatiated = false;
        }
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCam.enabled == false && editorCam.enabled == true)
        {
            editorMode = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            editorMode = false;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
