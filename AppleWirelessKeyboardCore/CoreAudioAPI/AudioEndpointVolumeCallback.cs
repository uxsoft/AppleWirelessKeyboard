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
    // This class implements the IAudioEndpointVolumeCallback interface,
    // it is implemented in this class because implementing it on AudioEndpointVolume 
    // (where the functionality is really wanted, would cause the OnNotify function 
    // to show up in the public API. 
    internal class AudioEndpointVolumeCallback : IAudioEndpointVolumeCallback    
    {
        private readonly AudioEndpointVolume _Parent;
        
        internal AudioEndpointVolumeCallback(AudioEndpointVolume parent)
        {
            _Parent = parent;
        }
        
        [PreserveSig] 
        public int OnNotify(IntPtr NotifyData)
        {
            //Since AUDIO_VOLUME_NOTIFICATION_DATA is dynamic in length based on the
            //number of audio channels available we cannot just call PtrToStructure 
            //to get all data, thats why it is split up into two steps, first the static
            //data is marshalled into the data structure, then with some IntPtr math the
            //remaining floats are read from memory.
            //
            var data = Marshal.PtrToStructure<AUDIO_VOLUME_NOTIFICATION_DATA>(NotifyData);
            
            //Determine offset in structure of the first float
            var Offset = Marshal.OffsetOf(typeof (AUDIO_VOLUME_NOTIFICATION_DATA), "ChannelVolume");
            //Determine offset in memory of the first float
            var FirstFloatPtr = (IntPtr) ((long) NotifyData + (long) Offset);

            var voldata = new float[data.nChannels];
            
            //Read all floats from memory.
            for (var i = 0; i < data.nChannels; i++)
                voldata[i] = Marshal.PtrToStructure<float>(FirstFloatPtr);

            //Create combined structure and Fire Event in parent class.
            var NotificationData = new AudioVolumeNotificationData(data.bMuted, data.fMasterVolume);
            _Parent.FireNotification(NotificationData);
            return 0; //S_OK
        }
    }
}
