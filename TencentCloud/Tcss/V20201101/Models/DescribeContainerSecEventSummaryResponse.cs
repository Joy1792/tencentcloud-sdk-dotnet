/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeContainerSecEventSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 未处理逃逸事件
        /// </summary>
        [JsonProperty("UnhandledEscapeCnt")]
        public ulong? UnhandledEscapeCnt{ get; set; }

        /// <summary>
        /// 未处理反弹shell事件
        /// </summary>
        [JsonProperty("UnhandledReverseShellCnt")]
        public ulong? UnhandledReverseShellCnt{ get; set; }

        /// <summary>
        /// 未处理高危系统调用
        /// </summary>
        [JsonProperty("UnhandledRiskSyscallCnt")]
        public ulong? UnhandledRiskSyscallCnt{ get; set; }

        /// <summary>
        /// 未处理异常进程
        /// </summary>
        [JsonProperty("UnhandledAbnormalProcessCnt")]
        public ulong? UnhandledAbnormalProcessCnt{ get; set; }

        /// <summary>
        /// 未处理文件篡改
        /// </summary>
        [JsonProperty("UnhandledFileCnt")]
        public ulong? UnhandledFileCnt{ get; set; }

        /// <summary>
        /// 未处理木马事件
        /// </summary>
        [JsonProperty("UnhandledVirusEventCnt")]
        public ulong? UnhandledVirusEventCnt{ get; set; }

        /// <summary>
        /// 未处理恶意外连事件
        /// </summary>
        [JsonProperty("UnhandledMaliciousConnectionEventCnt")]
        public ulong? UnhandledMaliciousConnectionEventCnt{ get; set; }

        /// <summary>
        /// 未处理k8sApi事件
        /// </summary>
        [JsonProperty("UnhandledK8sApiEventCnt")]
        public ulong? UnhandledK8sApiEventCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "UnhandledEscapeCnt", this.UnhandledEscapeCnt);
            this.SetParamSimple(map, prefix + "UnhandledReverseShellCnt", this.UnhandledReverseShellCnt);
            this.SetParamSimple(map, prefix + "UnhandledRiskSyscallCnt", this.UnhandledRiskSyscallCnt);
            this.SetParamSimple(map, prefix + "UnhandledAbnormalProcessCnt", this.UnhandledAbnormalProcessCnt);
            this.SetParamSimple(map, prefix + "UnhandledFileCnt", this.UnhandledFileCnt);
            this.SetParamSimple(map, prefix + "UnhandledVirusEventCnt", this.UnhandledVirusEventCnt);
            this.SetParamSimple(map, prefix + "UnhandledMaliciousConnectionEventCnt", this.UnhandledMaliciousConnectionEventCnt);
            this.SetParamSimple(map, prefix + "UnhandledK8sApiEventCnt", this.UnhandledK8sApiEventCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

