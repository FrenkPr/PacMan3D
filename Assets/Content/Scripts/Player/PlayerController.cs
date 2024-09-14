using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //debug pos: Vector3(707.479919,0,-62.5725098)

    [SerializeField] private float moveSpeed;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationDir = transform.localEulerAngles;
        rotationDir.y = InputsController.Instance.PlayerRotationDir;

        transform.localEulerAngles = rotationDir;

        characterController.Move(moveSpeed * transform.forward * Time.deltaTime);
    }
}
