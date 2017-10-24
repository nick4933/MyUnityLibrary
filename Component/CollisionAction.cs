using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLibrary.YesUnity.Component
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Rigidbody))]
    [AddComponentMenu("YesUnity/CollisionAction")]
    public class CollisionAction:MonoBehaviour
    {
        /// <summary>
        /// 开始碰撞
        /// </summary>
        public Action<Collision> CollisionEnter;
        private void OnCollisionEnter(Collision collision)
        {
            if (null != CollisionEnter)
                CollisionEnter(collision);
        }
        /// <summary>
        /// 保持碰撞
        /// </summary>
        public Action<Collision> CollisionStay;
        private void OnCollisionStay(Collision collision)
        {
            if (null != CollisionStay)
                CollisionStay(collision);
        }
        /// <summary>
        /// 碰撞结束
        /// </summary>
        public Action<Collision> CollisionExit;
        private void OnCollisionExit(Collision collision)
        {
            if (null != CollisionExit)
                CollisionExit(collision);
        }
        /// <summary>
        /// 2D开始碰撞
        /// </summary>
        public Action<Collision2D> CollisionEnter2D;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (null != CollisionEnter2D)
                CollisionEnter2D(collision);
        }
        /// <summary>
        /// 2D保持碰撞
        /// </summary>
        public Action<Collision2D> CollisionStay2D;
        private void OnCollisionStay2D(Collision2D collision)
        {
            if (null != CollisionStay2D)
                CollisionStay2D(collision);
        }
        /// <summary>
        /// 2D碰撞结束
        /// </summary>
        public Action<Collision2D> CollisionExit2D;
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (null != CollisionExit2D)
                CollisionExit2D(collision);
        }
    }
}
