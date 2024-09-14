using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RotationDirType
{
    LEFT,
    UP,
    RIGHT,
    DOWN,
    LENGTH
}

public class PlayerCanRotateCollider : MonoBehaviour
{
    // left collider pos: Vector3(-19,0,0)
    // right collider pos: Vector3(19,0,0)
    //up collider pos: Vector3(-1,0,17)
    //down collider pos: Vector3(-1,0,-17)

    [SerializeField] private RotationDirType dirType;

    private Transform playerTransform;
    private Vector3 posOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        posOffset = transform.position - playerTransform.position;
        posOffset.y = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        InputsController.Instance.rotationDirsAllowed[dirType] = false;
    }

    private void FixedUpdate()
    {
        //UI_Mngr.Instance.TextSprites[dirType.ToString()].text = dirType + " allowed = " + InputsController.Instance.rotationDirsAllowed[dirType];
        InputsController.Instance.rotationDirsAllowed[dirType] = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + posOffset;
    }
}
