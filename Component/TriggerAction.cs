using System;
using UnityEngine;

namespace UnityLibrary.YesUnity.Component
{
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("UnityLibrary/TriggerAction")]
    public class TriggerAction:MonoBehaviour
    {
        /// <summary>
        /// 进入触发
        /// </summary>
        public Action<Collider> TriggerEnter;

        private void OnTriggerEnter(Collider other)
        {
            if (null != TriggerEnter)
                TriggerEnter(other);
        }
        /// <summary>
        /// 停留触发
        /// </summary>
        public Action<Collider> TriggerStay;

        private void OnTriggerStay(Collider other)
        {
            if (null != TriggerStay)
                TriggerStay(other);
        }
        /// <summary>
        /// 离开触发
        /// </summary>
        public Action<Collider> TriggerExit;

        private void OnTriggerExit(Collider other)
        {
            if (null != TriggerExit)
                TriggerExit(other);
        }
        /// <summary>
        /// 2D进入触发
        /// </summary>
        public Action<Collider2D> TriggerEnter2D;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (null != TriggerEnter2D)
                TriggerEnter2D(collision);
        }
        /// <summary>
        /// 2D停留触发
        /// </summary>
        public Action<Collider2D> TriggerStay2D;

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (null != TriggerStay2D)
                TriggerStay2D(collision);
        }
        /// <summary>
        /// 2D离开触发
        /// </summary>
        public Action<Collider2D> TriggerExit2D;

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (null != TriggerExit2D)
                TriggerExit2D(collision);
        }
    }
}
