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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlHomePositionRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 看守位使能 0-停用看守位 1-启用看守位
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 预置位编码 范围1-8，启用看守位时必填
        /// </summary>
        [JsonProperty("PresetId")]
        public long? PresetId{ get; set; }

        /// <summary>
        /// 看守位自动归位时间， 启用看守位时必填
        /// </summary>
        [JsonProperty("ResetTime")]
        public long? ResetTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "PresetId", this.PresetId);
            this.SetParamSimple(map, prefix + "ResetTime", this.ResetTime);
        }
    }
}

