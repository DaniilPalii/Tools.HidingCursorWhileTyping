﻿using System.Windows.Input;

namespace HidingCursorWhileTyping.CursorVisibility
{
    internal static class Keys
    {
        public static bool IsPressed(this ModifierKeys key)
            => Keyboard.Modifiers.HasFlag(key);

        public static bool IsPressed(this Key key)
            => Keyboard.IsKeyDown(key);

        public static readonly IEnumerable<ModifierKeys> CommandModifierKeys = new ModifierKeys[]
        {
            ModifierKeys.Alt,
            ModifierKeys.Control,
            ModifierKeys.Windows,
        };

        public static readonly IEnumerable<Key> Symbolic = new Key[]
        {
            Key.A,
            Key.B,
            Key.C,
            Key.D,
            Key.E,
            Key.F,
            Key.G,
            Key.H,
            Key.I,
            Key.J,
            Key.K,
            Key.L,
            Key.M,
            Key.N,
            Key.O,
            Key.P,
            Key.Q,
            Key.R,
            Key.S,
            Key.T,
            Key.U,
            Key.V,
            Key.W,
            Key.X,
            Key.Y,
            Key.Z,
            Key.D1,
            Key.D2,
            Key.D3,
            Key.D4,
            Key.D5,
            Key.D6,
            Key.D7,
            Key.D8,
            Key.D9,
            Key.D0,
            Key.OemTilde,
            Key.CapsLock,
            Key.OemMinus,
            Key.OemPlus,
            Key.OemBackslash,
            Key.OemOpenBrackets,
            Key.OemCloseBrackets,
            Key.OemSemicolon,
            Key.OemQuotes,
            Key.OemPipe,
            Key.OemComma,
            Key.OemPeriod,
            Key.OemQuestion,
            Key.Divide,
            Key.Multiply,
            Key.Subtract,
            Key.Add,
            Key.Separator,
        };
    }
}
