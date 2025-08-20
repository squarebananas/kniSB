// Copyright (C)2021-2024 Nick Kastellanos

using System;
using Microsoft.Xna.Framework.Input;

namespace Microsoft.Xna.Platform.Input
{
    public sealed class ConcreteMouseCursor : MouseCursorStrategy
    {
        #region TODO https://github.com/kniEngine/kni/pull/2346

        string _cursorCSSPropertyValue;

        internal string CursorCSSPropertyValue { get { return _cursorCSSPropertyValue; } }

        #endregion

        public ConcreteMouseCursor(MouseCursorStrategy.MouseCursorType cursorType)
        {
            this._cursorType = cursorType;
            this._handle = IntPtr.Zero;

            #region TODO https://github.com/kniEngine/kni/pull/2346

            _cursorCSSPropertyValue = CursorTypeToCSSPropertyValue(cursorType);

            #endregion
        }

        #region TODO https://github.com/kniEngine/kni/pull/2346

        private string CursorTypeToCSSPropertyValue(MouseCursorStrategy.MouseCursorType cursorType)
        {
            switch (cursorType)
            {
                case MouseCursorStrategy.MouseCursorType.Arrow:
                    return "default";
                case MouseCursorStrategy.MouseCursorType.IBeam:
                    return "text";
                case MouseCursorStrategy.MouseCursorType.Wait:
                    return "wait";
                case MouseCursorStrategy.MouseCursorType.Crosshair:
                    return "crosshair";
                case MouseCursorStrategy.MouseCursorType.WaitArrow:
                    return "progress";
                case MouseCursorStrategy.MouseCursorType.SizeNWSE:
                    return "nwse-resize";
                case MouseCursorStrategy.MouseCursorType.SizeNESW:
                    return "nesw-resize";
                case MouseCursorStrategy.MouseCursorType.SizeWE:
                    return "ew-resize";
                case MouseCursorStrategy.MouseCursorType.SizeNS:
                    return "ns-resize";
                case MouseCursorStrategy.MouseCursorType.SizeAll:
                    return "move";
                case MouseCursorStrategy.MouseCursorType.No:
                    return "not-allowed";
                case MouseCursorStrategy.MouseCursorType.Hand:
                    return "pointer";

                default:
                    throw new InvalidOperationException("cursorType");
            }
        }

        #endregion

        public ConcreteMouseCursor(byte[] data, int w, int h, int originx, int originy)
        {
            throw new PlatformNotSupportedException();
        }

        protected override void Dispose(bool dispose)
        {
            if (dispose)
            {
            }

            base.Dispose(dispose);
        }

    }
}
