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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeYeheResourceLimitResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户父账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 允许创建的节点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateNodeLimit")]
        public ulong? CreateNodeLimit{ get; set; }

        /// <summary>
        /// 允许创建的集群数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateClusterLimit")]
        public ulong? CreateClusterLimit{ get; set; }

        /// <summary>
        /// 是否有监控开启权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnablePermMonitor")]
        public bool? EnablePermMonitor{ get; set; }

        /// <summary>
        /// 节点是否有admin的所有权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnablePermAdminNode")]
        public bool? EnablePermAdminNode{ get; set; }

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
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreateNodeLimit", this.CreateNodeLimit);
            this.SetParamSimple(map, prefix + "CreateClusterLimit", this.CreateClusterLimit);
            this.SetParamSimple(map, prefix + "EnablePermMonitor", this.EnablePermMonitor);
            this.SetParamSimple(map, prefix + "EnablePermAdminNode", this.EnablePermAdminNode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

