using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float moveSpeed;

    void Update()
    {
        // D�placement horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // D�placement vertical
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }

    internal void ImproveAttacks(int basicDamageIncrease, int specialDamageIncrease)
    {
        throw new NotImplementedException();
    }
    public void SlowPlayer(float slowAmount)
    {
        // Mettre ici le code pour ralentir le joueur
        // Par exemple, r�duire sa vitesse de d�placement
        moveSpeed *= slowAmount;
    }
}