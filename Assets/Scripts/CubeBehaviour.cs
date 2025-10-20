using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
   public float rotationSpeed = 50f;

   private int rotationDirection = 0;

    void Update()
    {
        if (rotationDirection != 0)
        {
            transform.Rotate(0, rotationSpeed * rotationDirection * Time.deltaTime,0, Space.World);
        }
    }

    public void RotateClockwise()
    {
      rotationDirection = 1;
      Debug.Log("Rotacion: Horaria");
    }

    public void RotateCounterClockwise()
    {
      rotationDirection = -1;
      Debug.Log("Rotacion: AntiHoraria");
    }

    public void StopRotation()
    {
      rotationDirection = 0;
      Debug.Log("Rotacion: Detenida");
    }

    public bool IsRotating()
    {
      return rotationDirection != 0;
    }

    public int GetRotationDirection()
    {
      return rotationDirection;
    }

}
