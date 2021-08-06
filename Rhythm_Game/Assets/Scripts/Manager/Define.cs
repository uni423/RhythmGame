namespace Define
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    //public class Skill
    //{
    //    public bool IsPractice = false;
    //    public float Distance;
    //    public float Damage;
    //    public float MaxCoolTime;
    //    public float NowCoolTime = 0;
    //    public float Time;

    //    public Skill(float time, float damage, float distance, float coolTime)
    //    {
    //        Time = time;
    //        Damage = damage;
    //        Distance = distance;
    //        MaxCoolTime = coolTime;
    //    }
    //}

    public enum Stage
    {
        Stage1 = 0
    }

    public enum nodeType 
    { 
        Wall = 0,
        Normal, 
        True
    }
}