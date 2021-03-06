using UnityEngine;
using System;
using System.Reflection;
namespace QY.Debug{
    [AddComponentMenu("Draw Collider/Draw Capsule Collider")]
    public class DrawCapsuleCollider : DrawColliderGeneric<CapsuleCollider> {
        protected override void OnDrawCollider(){
            DrawCapsule(targetCollider.transform, targetCollider.center, targetCollider.radius, targetCollider.height);
        }
    }
}
