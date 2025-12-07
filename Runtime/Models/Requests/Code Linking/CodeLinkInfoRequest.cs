using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Services.Authentication
{
    [Serializable]
    class CodeLinkInfoRequest
    {
        [JsonProperty("signInCode")]
        public string SignInCode { get; set; }
    }
}
