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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeShieldResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务状态: 0-请返回,1-已完成,2-处理中,3-处理出错,4-处理超时
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// app加固前的详细信息
        /// </summary>
        [JsonProperty("AppDetailInfo")]
        public AppDetailInfo AppDetailInfo{ get; set; }

        /// <summary>
        /// app加固后的详细信息
        /// </summary>
        [JsonProperty("ShieldInfo")]
        public ShieldInfo ShieldInfo{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 状态指引
        /// </summary>
        [JsonProperty("StatusRef")]
        public string StatusRef{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamObj(map, prefix + "AppDetailInfo.", this.AppDetailInfo);
            this.SetParamObj(map, prefix + "ShieldInfo.", this.ShieldInfo);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StatusRef", this.StatusRef);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

