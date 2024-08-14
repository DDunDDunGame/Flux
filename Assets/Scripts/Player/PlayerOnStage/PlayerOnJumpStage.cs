using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOnJumpStage : PlayerOnStage
{
    bool isAir = false;
    int jumpCount = 2;

    public PlayerOnJumpStage(Player player) : base(player) 
    {
        player.Rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
        player.transform.GetComponent<CircleCollider2D>().sharedMaterial = Resources.Load("Physics/Jump") as PhysicsMaterial2D;
    }
    public override void OnEnter()
    {
        player.Actions.Jump.Enable();
        player.Actions.Jump.Move.performed += Move;
        player.Actions.Jump.Move.canceled += Move;
        player.Actions.Jump.Jump.performed += Jump;
    }

    public override void OnUpdate()
    {
        if (isAir)
        {
            LandGround();
        }
    }

    public override void OnExit()
    {
        player.Actions.Jump.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        player.Rigid.velocity = new Vector2(moveInput.x * 5, player.Rigid.velocity.y);
    }

    private void Jump(InputAction.CallbackContext context)
    {
        if (!isAir && jumpCount > 0) 
        {
            isAir = true;
            jumpCount--;
            float JumpInput = player.Actions.Jump.Jump.ReadValue<float>();
            player.Rigid.AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        }
    }

    private void LandGround()
    {
        RaycastHit2D hitGround = Physics2D.Raycast(player.transform.position, Vector3.down, 0.55f, LayerMask.GetMask("Ground"));
        if (hitGround)
        {
            isAir = false;
            jumpCount = 2;
        }
    }
}
