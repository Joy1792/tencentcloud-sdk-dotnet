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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListConfigRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页数量。
        /// 取值范围：1~200
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量。
        /// 取值范围：最小值为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序类型(规则名称)。
        /// 倒序：desc，
        /// 顺序：asc
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 风险等级。
        /// 1：高风险，
        /// 2：中风险，
        /// 3：低风险。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong?[] RiskLevel{ get; set; }

        /// <summary>
        /// 规则状态。
        /// ACTIVE：启用
        /// UN_ACTIVE：停用
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 评估结果。
        /// COMPLIANT：合规
        /// NON_COMPLIANT：不合规
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string[] ComplianceResult{ get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "RiskLevel.", this.RiskLevel);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArraySimple(map, prefix + "ComplianceResult.", this.ComplianceResult);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
        }
    }
}

