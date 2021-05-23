/*
  LICENSE
  -------
  Copyright (C) 2007-2010 Ray Molenkamp

  This source code is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this source code or the software it produces.

  Permission is granted to anyone to use this source code for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this source code must not be misrepresented; you must not
     claim that you wrote the original source code.  If you use this source code
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original source code.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;
using AudioSwitch.CoreAudioApi.Interfaces;

namespace AudioSwitch.CoreAudioApi
{
    internal class MMDevice
    {
        private readonly IMMDevice _RealDevice;
        private PropertyStore? _PropertyStore;
        private AudioMeterInformation? _AudioMeterInformation;
        private AudioEndpointVolume? _AudioEndpointVolume;
        private AudioSessionManager? _AudioSessionManager;

        private static Guid IID_IAudioMeterInformation = typeof(IAudioMeterInformation).GUID;
        private static Guid IID_IAudioEndpointVolume = typeof(IAudioEndpointVolume).GUID;
        private static Guid IID_IAudioSessionManager = typeof(IAudioSessionManager2).GUID;

        private PropertyStore GetPropertyInformation()
        {
            IPropertyStore propstore;
            Marshal.ThrowExceptionForHR(_RealDevice.OpenPropertyStore(EStgmAccess.STGM_READ, out propstore));
            return new PropertyStore(propstore);
        }

        private AudioSessionManager GetAudioSessionManager()
        {
            object result;
            Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioSessionManager, CLSCTX.ALL, IntPtr.Zero, out result));
            return new AudioSessionManager((IAudioSessionManager2)result);
        }

        private AudioMeterInformation GetAudioMeterInformation()
        {
            object result;
            Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioMeterInformation, CLSCTX.ALL, IntPtr.Zero, out result));
            return new AudioMeterInformation((IAudioMeterInformation)result);
        }

        private AudioEndpointVolume GetAudioEndpointVolume()
        {
            object result;
            Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioEndpointVolume, CLSCTX.ALL, IntPtr.Zero, out result));
            return new AudioEndpointVolume((IAudioEndpointVolume)result);
        }

        public AudioSessionManager AudioSessionManager
        {
            get
            {
                if (_AudioSessionManager == null)
                    _AudioSessionManager = GetAudioSessionManager();

                return _AudioSessionManager;
            }
        }

        public AudioMeterInformation AudioMeterInformation
        {
            get
            {
                if (_AudioMeterInformation == null)
                    _AudioMeterInformation = GetAudioMeterInformation();

                return _AudioMeterInformation;
            }
        }

        public AudioEndpointVolume AudioEndpointVolume
        {
            get
            {
                if (_AudioEndpointVolume == null)
                    _AudioEndpointVolume = GetAudioEndpointVolume();

                return _AudioEndpointVolume;
            }
        }

        private PropertyStore PropertyInformation
        {
            get
            {
                if (_PropertyStore == null)
                    _PropertyStore = GetPropertyInformation();
                
                return _PropertyStore;
            }
        }

        public string FriendlyName
        {
            get
            {
                return (string?)PropertyInformation[PKEY.PKEY_DeviceInterface_FriendlyName]?.PropVariant.GetValue() ?? "Unknown";
            }
        }

        public string IconPath
        {
            get
            {
                return (string?)PropertyInformation[PKEY.PKEY_DeviceClass_IconPath]?.PropVariant.GetValue() ?? "Unknown";
            }
        }

        public string ID
        {
            get
            {
                string Result;
                Marshal.ThrowExceptionForHR(_RealDevice.GetId(out Result));
                return Result;
            }
        }

        internal MMDevice(IMMDevice realDevice)
        {
            _RealDevice = realDevice;
        }
    }
}
