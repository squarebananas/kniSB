using System;

namespace Microsoft.Xna.Framework.XR
{
    public struct HandJointState
    {
        public Pose3 Pose;
        public float Radius;
        public Vector3 LinearVelocity;

        public Matrix Transform
        {
            get { return Matrix.CreateFromPose(Pose); }
        }
    }
}
