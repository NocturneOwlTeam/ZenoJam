using UnityEngine;

namespace Nocturne.Enums
{
    public enum PlayerStatus
    {
        Idle,
        Walking,
        Sprinting,
        Crouching
    }

    public enum JumpState
    {
        Jumping,
        DoubleJumping,
        InfiniteJumping,
        Falling,
        None
    }

    public enum DoorStatus
    {
        Open,
        Closed,
        Locked
    }

    public enum ObjectStatus
    {
        Idle,
        Used
    }

    public enum PlayerAnimatorLayers
    {
        Walk,
        Idle
    }

    public enum AttributeType
    {
        Strength,
        Intelligence,
        Dexterity
    }

    public enum ItemType
    {
        Healable,
        ManaGenerator,
        Standard
    }

    public enum DoorState
    {
        Open,
        Closed,
        Locked
    }

    public enum AntiAliasingMethod
    {
        None,
        FXAA,
        MSAA,
        TAA
    }

    public enum Language
    {
        English,
        Spanish
    }

    public static class PlayerLayersExtensions
    {
        public static string GetLayer(this PlayerAnimatorLayers layer)
        {
            switch (layer)
            {
                case PlayerAnimatorLayers.Walk: return "Walk";
                default: return "Idle";
            }
        }
    }
}