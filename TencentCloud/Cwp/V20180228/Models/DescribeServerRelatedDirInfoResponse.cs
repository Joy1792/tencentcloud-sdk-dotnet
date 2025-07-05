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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerRelatedDirInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 服务器名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 服务器IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 防护目录数量
        /// </summary>
        [JsonProperty("ProtectDirNum")]
        public ulong? ProtectDirNum{ get; set; }

        /// <summary>
        /// 防护文件数量
        /// </summary>
        [JsonProperty("ProtectFileNum")]
        public ulong? ProtectFileNum{ get; set; }

        /// <summary>
        /// 防篡改数量
        /// </summary>
        [JsonProperty("ProtectTamperNum")]
        public ulong? ProtectTamperNum{ get; set; }

        /// <summary>
        /// 防护软链数量
        /// </summary>
        [JsonProperty("ProtectLinkNum")]
        public ulong? ProtectLinkNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "ProtectDirNum", this.ProtectDirNum);
            this.SetParamSimple(map, prefix + "ProtectFileNum", this.ProtectFileNum);
            this.SetParamSimple(map, prefix + "ProtectTamperNum", this.ProtectTamperNum);
            this.SetParamSimple(map, prefix + "ProtectLinkNum", this.ProtectLinkNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

