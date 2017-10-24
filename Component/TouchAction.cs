using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLibrary.YesUnity.Component
{
    /// <summary>
    /// 触摸动作检测基类
    /// </summary>
    [AddComponentMenu("YesUnity/TouchAction")]
    public class TouchAction:MonoBehaviour
    {
        /// <summary>
        /// 开始单指触摸
        /// </summary>
        public Action<Vector2> OneTouchBegin;
        /// <summary>
        /// 单指触摸移动
        /// </summary>
        public Action<Vector2> OneTouchMove;
        /// <summary>
        /// 结束单指触摸
        /// </summary>
        public Action<Vector2> OneTouchEnd;
        /// <summary>
        /// 开始双指触摸
        /// </summary>
        public Action<Vector2, Vector2> TwoTouchBegin;
        /// <summary>
        /// 双指触摸移动
        /// </summary>
        public Action<Vector2, Vector2> TwoTouchMove;
        /// <summary>
        /// 双指触摸暂停
        /// </summary>
        public Action<Vector2, Vector2> TwoTouchPause;
        /// <summary>
        /// 结束双指触摸
        /// </summary>
        public Action<Vector2, Vector2> TwoTouchEnd;
        /// <summary>
        /// 触摸监测（作为基类基础方法）
        /// </summary>
        public virtual void TouchControl()
        {
            if (Input.touchCount <= 0)
            {
                return;
            }
            else if (Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if (OneTouchBegin != null)
                        OneTouchBegin(Input.GetTouch(0).position);
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    if (OneTouchMove != null)
                        OneTouchMove(Input.GetTouch(0).deltaPosition);
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    if (OneTouchEnd != null)
                        OneTouchEnd(Input.GetTouch(0).deltaPosition);
                }
            }
            else if (Input.touchCount > 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(1).phase == TouchPhase.Began)
                {
                    if (TwoTouchBegin != null)
                        TwoTouchBegin(Input.GetTouch(0).position, Input.GetTouch(1).position);
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Stationary && Input.GetTouch(1).phase == TouchPhase.Stationary)
                {
                    if (TwoTouchPause != null)
                        TwoTouchPause(Input.GetTouch(0).position, Input.GetTouch(1).position);
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
                {
                    if (TwoTouchMove != null)
                        TwoTouchMove(Input.GetTouch(0).position, Input.GetTouch(1).position);
                }
                else if (Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(1).phase == TouchPhase.Ended)
                {
                    if (TwoTouchEnd != null)
                        TwoTouchEnd(Input.GetTouch(0).position, Input.GetTouch(1).position);
                }
            }
        }
    }
}
