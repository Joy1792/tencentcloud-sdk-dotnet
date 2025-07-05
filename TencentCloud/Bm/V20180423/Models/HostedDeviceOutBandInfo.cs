/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostedDeviceOutBandInfo : AbstractModel
    {
        
        /// <summary>
        /// 物理机ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 带外IP
        /// </summary>
        [JsonProperty("OutBandIp")]
        public string OutBandIp{ get; set; }

        /// <summary>
        /// VPN的IP
        /// </summary>
        [JsonProperty("VpnIp")]
        public string VpnIp{ get; set; }

        /// <summary>
        /// VPN的端口
        /// </summary>
        [JsonProperty("VpnPort")]
        public ulong? VpnPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OutBandIp", this.OutBandIp);
            this.SetParamSimple(map, prefix + "VpnIp", this.VpnIp);
            this.SetParamSimple(map, prefix + "VpnPort", this.VpnPort);
        }
    }
}

