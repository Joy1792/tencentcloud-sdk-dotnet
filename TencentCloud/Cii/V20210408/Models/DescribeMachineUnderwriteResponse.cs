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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachineUnderwriteResponse : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云主账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 操作人子账户ID
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 保单ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 主任务ID
        /// </summary>
        [JsonProperty("MainTaskId")]
        public string MainTaskId{ get; set; }

        /// <summary>
        /// 核保任务ID
        /// </summary>
        [JsonProperty("UnderwriteTaskId")]
        public string UnderwriteTaskId{ get; set; }

        /// <summary>
        /// 结果状态：
        /// 0：返回成功
        /// 1：结果未生成
        /// 2：结果生成失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 机器核保结果
        /// </summary>
        [JsonProperty("UnderwriteResults")]
        public MachineUnderwriteOutput[] UnderwriteResults{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "MainTaskId", this.MainTaskId);
            this.SetParamSimple(map, prefix + "UnderwriteTaskId", this.UnderwriteTaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "UnderwriteResults.", this.UnderwriteResults);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

