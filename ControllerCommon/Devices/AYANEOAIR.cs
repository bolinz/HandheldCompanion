using ControllerCommon.Controllers;
using System.Collections.Generic;
using System.Numerics;
using WindowsInput.Events;

namespace ControllerCommon.Devices
{
    public class AYANEOAIR : Device
    {
        public AYANEOAIR() : base()
        {
            this.ProductSupported = true;

            // device specific settings
            this.ProductIllustration = "device_aya_air";
            this.ProductModel = "AYANEOAir";

            // https://www.amd.com/en/products/apu/amd-ryzen-5-5560u
            this.nTDP = new double[] { 12, 12, 15 };
            this.cTDP = new double[] { 8, 15 };
            this.GfxClock = new double[] { 100, 1600 };

            this.AngularVelocityAxisSwap = new()
            {
                { 'X', 'X' },
                { 'Y', 'Z' },
                { 'Z', 'Y' },
            };

            this.AccelerationAxis = new Vector3(-1.0f, 1.0f, -1.0f);
            this.AccelerationAxisSwap = new()
            {
                { 'X', 'X' },
                { 'Y', 'Z' },
                { 'Z', 'Y' },
            };

            listeners.Add(new DeviceChord("Custom Key Top Right",
                new List<KeyCode>() { KeyCode.RControlKey, KeyCode.LWin, KeyCode.F10 },
                new List<KeyCode>() { KeyCode.F10, KeyCode.LWin, KeyCode.RControlKey },
                false, ControllerButtonFlags.OEM3
                ));

            listeners.Add(new DeviceChord("Custom Key Top Left",
                new List<KeyCode>() { KeyCode.RControlKey, KeyCode.LWin, KeyCode.F11 },
                new List<KeyCode>() { KeyCode.F11, KeyCode.LWin, KeyCode.RControlKey },
                false, ControllerButtonFlags.OEM4
                ));

            listeners.Add(new DeviceChord("Custom Key Big",
                new List<KeyCode>() { KeyCode.RControlKey, KeyCode.LWin, KeyCode.F12 },
                new List<KeyCode>() { KeyCode.F12, KeyCode.LWin, KeyCode.RControlKey },
                false, ControllerButtonFlags.OEM1
                ));

            listeners.Add(new DeviceChord("Custom Key Small",
                new List<KeyCode>() { KeyCode.LWin, KeyCode.D },
                new List<KeyCode>() { KeyCode.LWin, KeyCode.D },
                false, ControllerButtonFlags.OEM2
                ));
        }
    }
}
