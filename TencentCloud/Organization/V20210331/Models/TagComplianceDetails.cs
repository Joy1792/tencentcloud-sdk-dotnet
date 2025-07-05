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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagComplianceDetails : AbstractModel
    {
        
        /// <summary>
        /// 合规状态。true-合规，false-不合规
        /// </summary>
        [JsonProperty("ComplianceStatus")]
        public bool? ComplianceStatus{ get; set; }

        /// <summary>
        /// 值不合规的标签键列表。
        /// </summary>
        [JsonProperty("KeysWithNonCompliantValues")]
        public string[] KeysWithNonCompliantValues{ get; set; }

        /// <summary>
        /// 键不合规的标签键列表。
        /// </summary>
        [JsonProperty("NonCompliantKeys")]
        public string[] NonCompliantKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComplianceStatus", this.ComplianceStatus);
            this.SetParamArraySimple(map, prefix + "KeysWithNonCompliantValues.", this.KeysWithNonCompliantValues);
            this.SetParamArraySimple(map, prefix + "NonCompliantKeys.", this.NonCompliantKeys);
        }
    }
}

