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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNotebookSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例总数
        /// </summary>
        [JsonProperty("AllInstanceCnt")]
        public long? AllInstanceCnt{ get; set; }

        /// <summary>
        /// 计费实例总数
        /// </summary>
        [JsonProperty("BillingInstanceCnt")]
        public long? BillingInstanceCnt{ get; set; }

        /// <summary>
        /// 仅存储计费的实例总数
        /// </summary>
        [JsonProperty("StorageOnlyBillingInstanceCnt")]
        public long? StorageOnlyBillingInstanceCnt{ get; set; }

        /// <summary>
        /// 计算和存储都计费的实例总数
        /// </summary>
        [JsonProperty("ComputingBillingInstanceCnt")]
        public long? ComputingBillingInstanceCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "AllInstanceCnt", this.AllInstanceCnt);
            this.SetParamSimple(map, prefix + "BillingInstanceCnt", this.BillingInstanceCnt);
            this.SetParamSimple(map, prefix + "StorageOnlyBillingInstanceCnt", this.StorageOnlyBillingInstanceCnt);
            this.SetParamSimple(map, prefix + "ComputingBillingInstanceCnt", this.ComputingBillingInstanceCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

