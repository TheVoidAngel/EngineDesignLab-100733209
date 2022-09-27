using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    PlayerCharAction inputAction;

    public Camera mainCam;
    public Camera editorCam;

    public GameObject prefab1;
    public GameObject prefab2;

    GameObject item;

    public bool editorMode = false;
    bool instatiated = false;

    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        inputAction = new PlayerCharAction();

        inputAction.Editor.EnableEditor.performed += cntxt => SwitchCamera();

        inputAction.Editor.Additem1.performed += cntxt => AddItem(1);
        inputAction.Editor.Additem2.performed += cntxt => AddItem(2);
        inputAction.Editor.Dropitem.performed += cntxt => DropItem();
        mainCam.enabled = true;
        editorCam.enabled = false;
    }

    private void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;
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
