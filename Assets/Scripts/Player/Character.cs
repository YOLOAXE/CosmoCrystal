﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    #region Locomotion
    [Header("Mouvement")]
    [SerializeField] protected float walkSpeed = 1.0f;
    [SerializeField] protected float runSpeed = 2.0f;
    [SerializeField] protected float gravityValue = -9.81f;
    [SerializeField] protected float gravityAcelerationMultipliyer = 1.0f;
    [SerializeField] protected bool isInteract = false;

    #region timerVar
    protected float notGroundTime = 0.0f;
    #endregion

    #region StatePersonnage

    [SerializeField] protected bool isDead = false;

    #endregion


    #endregion
    #region GetterSetter
    public bool IsInteract
    {
        get
        {
            return isInteract;
        }
        set
        {
            isInteract = value;
        }
    }

    public virtual float SpeedModifier { set { } get { return 0.0f; } }
    public virtual float WalkSpeed { get { return walkSpeed; } }
    #endregion

    protected virtual void Awake() { }
    protected virtual void Start() { }
    protected virtual void Update() { }
}
