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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulFixStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞修复进度 1-100；
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 漏洞对应主机修复状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostList")]
        public VulFixStatusHostInfo[] HostList{ get; set; }

        /// <summary>
        /// 漏洞修复失败主机数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailCnt")]
        public ulong? FailCnt{ get; set; }

        /// <summary>
        /// 修复成功的数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixSuccessCnt")]
        public ulong? FixSuccessCnt{ get; set; }

        /// <summary>
        /// 修复方式 0组件更新或者安装补丁,1禁用服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixMethod")]
        public ulong? FixMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamArrayObj(map, prefix + "HostList.", this.HostList);
            this.SetParamSimple(map, prefix + "FailCnt", this.FailCnt);
            this.SetParamSimple(map, prefix + "FixSuccessCnt", this.FixSuccessCnt);
            this.SetParamSimple(map, prefix + "FixMethod", this.FixMethod);
        }
    }
}

