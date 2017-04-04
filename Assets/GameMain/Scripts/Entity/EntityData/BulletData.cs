﻿using System;
using UnityEngine;

namespace AirForce
{
    [Serializable]
    public class BulletData : EntityData
    {
        [SerializeField]
        private int m_OwnerId = 0;

        [SerializeField]
        private CampType m_OwnerCamp = CampType.Unknown;

        [SerializeField]
        private int m_Attack = 0;

        [SerializeField]
        private float m_Speed = 0f;

        public BulletData(int entityId, int typeId, int ownerId, CampType ownerCamp, int attack)
            : base(entityId, typeId)
        {
            m_OwnerId = ownerId;
            m_OwnerCamp = ownerCamp;
            m_Attack = attack;
            m_Speed = 20f;
        }

        public int OwnerId
        {
            get
            {
                return m_OwnerId;
            }
        }

        public CampType OwnerCamp
        {
            get
            {
                return m_OwnerCamp;
            }
        }

        public int Attack
        {
            get
            {
                return m_Attack;
            }
        }

        public float Speed
        {
            get
            {
                return m_Speed;
            }
        }
    }
}
