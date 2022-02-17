﻿using System;
using MVP;
public interface IPlayerView : IView
{
    event Action OnEnabledEvent;
    event Action OnDisabledEvent;
        
    void MoveInDirectionX(float direction);
    
    void StopMove();    

    void OnJump();    

    bool IsGrounded();
    void Die();
}