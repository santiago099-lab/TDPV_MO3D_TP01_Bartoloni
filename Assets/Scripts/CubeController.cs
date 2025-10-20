using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;

    void Start()
    {
        cubeBehaviour = GetComponent<CubeBehaviour>();

        if (cubeBehaviour == null)
        {
            Debug.LogError("no se encontro el componente CubeBehaviour en este GameObject");
        }
    }

    void Update()
    {
        if (cubeBehaviour != null) return;

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            cubeBehaviour.RotateClockwise();
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            cubeBehaviour.RotateCounterClockwise();
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.S))
        {
            cubeBehaviour.StopRotation();
        }
    }
}
