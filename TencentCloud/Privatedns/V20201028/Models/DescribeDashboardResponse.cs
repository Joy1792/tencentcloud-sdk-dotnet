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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDashboardResponse : AbstractModel
    {
        
        /// <summary>
        /// 私有域解析总数
        /// </summary>
        [JsonProperty("ZoneTotal")]
        public long? ZoneTotal{ get; set; }

        /// <summary>
        /// 私有域关联VPC数量
        /// </summary>
        [JsonProperty("ZoneVpcCount")]
        public long? ZoneVpcCount{ get; set; }

        /// <summary>
        /// 历史请求量总数
        /// </summary>
        [JsonProperty("RequestTotalCount")]
        public long? RequestTotalCount{ get; set; }

        /// <summary>
        /// 流量包用量
        /// </summary>
        [JsonProperty("FlowUsage")]
        public FlowUsage[] FlowUsage{ get; set; }

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
            this.SetParamSimple(map, prefix + "ZoneTotal", this.ZoneTotal);
            this.SetParamSimple(map, prefix + "ZoneVpcCount", this.ZoneVpcCount);
            this.SetParamSimple(map, prefix + "RequestTotalCount", this.RequestTotalCount);
            this.SetParamArrayObj(map, prefix + "FlowUsage.", this.FlowUsage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

