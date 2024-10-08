using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerOnBarrierStage : PlayerOnStage
{
    Sprite playerSprite;
    public PlayerOnBarrierStage(Player player) : base(player) 
    {
        playerSprite = Resources.Load<Sprite>("Arts/Barrier/Player");
    }
    public override void OnEnter()
    {
        player.Rigid.velocity = Vector2.zero;
        player.Rigid.angularDrag = 0;
        player.Rigid.bodyType = RigidbodyType2D.Kinematic;
        player.Sprite.sprite = player.Circle;

        player.Actions.Barrier.Enable();
        player.Actions.Barrier.Move.performed += Move;
        player.Actions.Barrier.Move.canceled += Move;
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        player.Actions.Barrier.Disable();
        player.Rigid.angularVelocity = 0;
        player.transform.rotation = Quaternion.identity;
        player.Rigid.bodyType = RigidbodyType2D.Dynamic;
    }

    private void Move(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        player.Rigid.angularVelocity = -input.x * 400;
    }
}
