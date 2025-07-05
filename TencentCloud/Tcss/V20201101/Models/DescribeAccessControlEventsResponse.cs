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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessControlEventsResponse : AbstractModel
    {
        
        /// <summary>
        /// 事件总数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 访问控制事件数组
        /// </summary>
        [JsonProperty("EventSet")]
        public AccessControlEventInfo[] EventSet{ get; set; }

        /// <summary>
        /// 支持的内核版本
        /// </summary>
        [JsonProperty("SupportCoreVersion")]
        public string SupportCoreVersion{ get; set; }

        /// <summary>
        /// 拦截失败可能的原因
        /// </summary>
        [JsonProperty("InterceptionFailureTip")]
        public string InterceptionFailureTip{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "EventSet.", this.EventSet);
            this.SetParamSimple(map, prefix + "SupportCoreVersion", this.SupportCoreVersion);
            this.SetParamSimple(map, prefix + "InterceptionFailureTip", this.InterceptionFailureTip);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

