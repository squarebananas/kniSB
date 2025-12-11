using System;
using Microsoft.Xna.Platform.XR;

namespace Microsoft.Xna.Framework.XR
{
    public sealed class HandJointCollection
       : IPlatformHandJointCollectionStrategy
    {
        private HandJointCollectionStrategy _strategy;

        HandJointCollectionStrategy IPlatformHandJointCollectionStrategy.Strategy { get { return _strategy; } }

        internal HandJointCollection(XRDeviceStrategy xrDeviceStrategy, int handIndex)
        {
            _strategy = xrDeviceStrategy.CreateHandJointCollectionStrategy(handIndex);
        }

        public int Length { get { return _strategy.Length; } }

        public HandJointState this[XRHandJoint handJoint]
        {
            get { return _strategy[handJoint]; }
        }

        public HandJointState this[int index]
        {
            get { return _strategy[index]; }
        }
    }
}
