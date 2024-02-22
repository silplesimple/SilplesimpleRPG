using EnumTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTypes
{
    public enum AttackTypes
    { 
        None,Melee, Range
    }

    public enum CardRanks
    { 
        Normal,Special,Rare
    }
    
    public enum CardHowToUses
    {
        Normal,TargetGround,TargetEntity
    }

    public enum CardAfterUses
    {
        Discard,Destruct,Spawn
    }

    public enum GameFlowState
    {
        InitGame,SelectStage,Setting,Wave,EventFlow,Ending
    }
}

namespace Structs
{
    [SerializeField]
    public struct AttackData
    {
        public AttackTypes attackType;
        public int attackAnimationIndex;

        
    }
    [SerializeField]
    public struct StatModifierData
    {
        public StatType
    }
}
public class PlayerEX : MonoBehaviour
{
    AttackTypes attackTypes = 
}
