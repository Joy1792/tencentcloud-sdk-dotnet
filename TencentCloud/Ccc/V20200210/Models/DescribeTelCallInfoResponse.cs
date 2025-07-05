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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTelCallInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 呼出套餐包消耗分钟数
        /// </summary>
        [JsonProperty("TelCallOutCount")]
        public long? TelCallOutCount{ get; set; }

        /// <summary>
        /// 呼入套餐包消耗分钟数
        /// </summary>
        [JsonProperty("TelCallInCount")]
        public long? TelCallInCount{ get; set; }

        /// <summary>
        /// 坐席使用统计个数
        /// </summary>
        [JsonProperty("SeatUsedCount")]
        public long? SeatUsedCount{ get; set; }

        /// <summary>
        /// 音频套餐包消耗分钟数
        /// </summary>
        [JsonProperty("VoipCallInCount")]
        [System.Obsolete]
        public long? VoipCallInCount{ get; set; }

        /// <summary>
        /// 音频套餐包消耗分钟数
        /// </summary>
        [JsonProperty("VOIPCallInCount")]
        public long? VOIPCallInCount{ get; set; }

        /// <summary>
        /// 离线语音转文字套餐包消耗分钟数
        /// </summary>
        [JsonProperty("AsrOfflineCount")]
        public long? AsrOfflineCount{ get; set; }

        /// <summary>
        /// 实时语音转文字套餐包消耗分钟数
        /// </summary>
        [JsonProperty("AsrRealtimeCount")]
        public long? AsrRealtimeCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TelCallOutCount", this.TelCallOutCount);
            this.SetParamSimple(map, prefix + "TelCallInCount", this.TelCallInCount);
            this.SetParamSimple(map, prefix + "SeatUsedCount", this.SeatUsedCount);
            this.SetParamSimple(map, prefix + "VoipCallInCount", this.VoipCallInCount);
            this.SetParamSimple(map, prefix + "VOIPCallInCount", this.VOIPCallInCount);
            this.SetParamSimple(map, prefix + "AsrOfflineCount", this.AsrOfflineCount);
            this.SetParamSimple(map, prefix + "AsrRealtimeCount", this.AsrRealtimeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

