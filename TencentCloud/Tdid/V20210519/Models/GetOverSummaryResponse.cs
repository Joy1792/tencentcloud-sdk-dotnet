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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetOverSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户参与应用的统计指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppCounter")]
        public ResourceCounterData AppCounter{ get; set; }

        /// <summary>
        /// 用户部署应用的统计指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserCounter")]
        public ResourceCounterData UserCounter{ get; set; }

        /// <summary>
        /// 用户参与的应用总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppCnt")]
        public ulong? AppCnt{ get; set; }

        /// <summary>
        /// 用户部署的应用总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployCnt")]
        public ulong? DeployCnt{ get; set; }

        /// <summary>
        /// 部署网络子链总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChainCnt")]
        public ulong? ChainCnt{ get; set; }

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
            this.SetParamObj(map, prefix + "AppCounter.", this.AppCounter);
            this.SetParamObj(map, prefix + "UserCounter.", this.UserCounter);
            this.SetParamSimple(map, prefix + "AppCnt", this.AppCnt);
            this.SetParamSimple(map, prefix + "DeployCnt", this.DeployCnt);
            this.SetParamSimple(map, prefix + "ChainCnt", this.ChainCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

