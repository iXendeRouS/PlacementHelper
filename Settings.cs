﻿using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;
using UnityEngine;

namespace PlacementHelper
{
    public class Settings : ModSettings
    {
        public static readonly ModSettingCategory Directions = new("Directions");
        public static readonly ModSettingCategory Rotation = new("Rotation");

        public static readonly ModSettingHotkey UpHotkey = new(KeyCode.UpArrow)
        {
            category = Directions,
            description = "Snap the tower upwards to the furthest valid pixel placement."
        };

        public static readonly ModSettingHotkey DownHotkey = new(KeyCode.DownArrow)
        {
            category = Directions,
            description = "Snap the tower downwards to the furthest valid pixel placement."
        };

        public static readonly ModSettingHotkey LeftHotkey = new(KeyCode.LeftArrow)
        {
            category = Directions,
            description = "Snap the tower left to the furthest valid pixel placement."
        };

        public static readonly ModSettingHotkey RightHotkey = new(KeyCode.RightArrow)
        {
            category = Directions,
            description = "Snap the tower right to the furthest valid pixel placement."
        };

        public static readonly ModSettingBool invertNudgeModifier = new(false)
        {
            description = "Nudge by default and snap when the modifier key is pressed."
        };

        public static readonly ModSettingHotkey NudgeModifierHotkey = new(KeyCode.RightControl)
        {
            description = "While down, nudge by 1 pixel instead of Snapping."
        };

        public static readonly ModSettingHotkey SqueezeHotkey = new(KeyCode.LeftShift)
        {
            description = "Squeeze a tower between the closest two towers if both are circular. Subpixel."
        };

        public static readonly ModSettingHotkey RotateClockwiseHotkey = new(KeyCode.E)
        {
            category = Rotation,
            description = "Rotate the tower clockwise around the closest circular tower."
        };

        public static readonly ModSettingHotkey RotateAnticlockwiseHotkey = new(KeyCode.Q)
        {
            category = Rotation,
            description = "Rotate the tower anti-clockwise around the closest circular tower."
        };

        public static readonly ModSettingHotkey PlaceSubpixelTowerHotkey = new(KeyCode.LeftControl)
        {
            description = "Place the squeezed or rotated tower subpixel."
        };

        public static readonly ModSettingInt RotatePrecision = new(360)
        {
            category = Rotation,
            description = "Rotate at an angle of 2 * pi / value. Higher -> more precise placement but may take slightly longer.",
            min = 360,
            max = 36000
        };
    }
}
