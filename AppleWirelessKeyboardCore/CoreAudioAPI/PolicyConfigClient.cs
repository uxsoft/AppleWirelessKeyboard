using System.Diagnostics;
using System.Runtime.InteropServices;
using AudioSwitch.CoreAudioApi.Interfaces;

namespace AudioSwitch.CoreAudioApi
{
    [ComImport, Guid("870AF99C-171D-4F9E-AF0D-E63DF40C2BC9")]
    internal class _PolicyConfigClient
    {
    }

    public class PolicyConfigClient
    {
        private readonly IPolicyConfig? _PolicyConfig;

        public PolicyConfigClient()
        {
            _PolicyConfig = new _PolicyConfigClient() as IPolicyConfig;
            if (_PolicyConfig == null)
                Debug.WriteLine("Unable to reference IPolicyConfig COM interface!");
        }
        

        public void SetDefaultEndpoint(string devID, ERole eRole)
        {
            if(_PolicyConfig != null)
                Marshal.ThrowExceptionForHR(_PolicyConfig.SetDefaultEndpoint(devID, eRole));
        }
    }
}