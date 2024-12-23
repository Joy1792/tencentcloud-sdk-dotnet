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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskLevelMatrix : AbstractModel
    {
        
        /// <summary>
        /// 存储id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 分类分级levelID
        /// </summary>
        [JsonProperty("SensitiveLevelId")]
        public long? SensitiveLevelId{ get; set; }

        /// <summary>
        /// 分类分级名称
        /// </summary>
        [JsonProperty("SensitiveLevelName")]
        public string SensitiveLevelName{ get; set; }

        /// <summary>
        /// 漏洞级别
        /// </summary>
        [JsonProperty("VulnerabilityLevel")]
        public string VulnerabilityLevel{ get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SensitiveLevelId", this.SensitiveLevelId);
            this.SetParamSimple(map, prefix + "SensitiveLevelName", this.SensitiveLevelName);
            this.SetParamSimple(map, prefix + "VulnerabilityLevel", this.VulnerabilityLevel);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
        }
    }
}

