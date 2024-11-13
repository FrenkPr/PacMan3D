using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputsController : Singleton<InputsController>
{
    [SerializeField] private float playerRotationDir;
    [SerializeField] private string[] rotationDirsDebug;

    private PlayerInputs p;
    public Dictionary<string, InputAction> Inputs { get; private set; }

    public Dictionary<RotationDirType, bool> rotationDirsAllowed;
    public Dictionary<float, RotationDirType> rotationDirsType;
    public float PlayerRotationDir { get { return playerRotationDir; } private set { playerRotationDir = value; } }
    private float? nextRotationDir;

    // Start is called before the first frame update
    void Awake()
    {
        p = new PlayerInputs();
        Inputs = new Dictionary<string, InputAction>();

        InputSystem.settings.maxEventBytesPerUpdate = 0;

        for (int i = 0; i < p.asset.actionMaps.Count; i++)
        {
            for (int j = 0; j < p.asset.actionMaps[i].actions.Count; j++)
            {
                Inputs[p.asset.actionMaps[i].actions[j].name] = p.asset.actionMaps[i].actions[j];
            }
        }

        //print(p.asset.actionMaps[0].actions[0].name);

        rotationDirsAllowed = new Dictionary<RotationDirType, bool>();

        //initializes all rotation directions to true
        for (int i = 0; i < (int)RotationDirType.LENGTH; i++)
        {
            rotationDirsAllowed[(RotationDirType)i] = true;
        }

        //initializes rotation direction types
        //useful to understand in which direction the player is going
        //using the euler y angle
        rotationDirsType = new Dictionary<float, RotationDirType>();
        float rotationDir = -90;

        for (int i = 0; i < (int)RotationDirType.LENGTH; i++)
        {
            rotationDirsType[rotationDir] = (RotationDirType)i;
            rotationDir += 90;
        }

        //rotationDirsDebug = new string[(int)RotationDirType.LENGTH];
    }

    private void OnEnable()
    {
        p.Enable();
    }

    private void OnDisable()
    {
        p.Disable();
    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else
            Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        if (Inputs["QuitGameBtnPressed"].triggered)
        {
            QuitGame();
        }

        float rotationDir = Inputs["RotationDir"].ReadValue<float>();

        if (rotationDir != 0)
        {
            if (rotationDir == -1)
            {
                rotationDir = 0;
            }

            nextRotationDir = rotationDir;
        }

        if (nextRotationDir != null && rotationDirsAllowed[rotationDirsType[(float)nextRotationDir]])
        {
            PlayerRotationDir = (float)nextRotationDir;
            nextRotationDir = null;
        }

        //for (int i = 0; i < (int)RotationDirType.LENGTH; i++)
        //{
        //    rotationDirsDebug[i] = (RotationDirType)i + " allowed = " + rotationDirsAllowed[(RotationDirType)i];
        //    //UI_Mngr.Instance.TextSprites[((RotationDirType)i).ToString()].text = rotationDirsDebug[i];
        //}
    }
}
