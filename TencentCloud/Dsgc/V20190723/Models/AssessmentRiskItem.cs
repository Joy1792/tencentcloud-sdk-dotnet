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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssessmentRiskItem : AbstractModel
    {
        
        /// <summary>
        /// 脆弱项id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// 脆弱性级别
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 关联模板个数
        /// </summary>
        [JsonProperty("ReferTemplateCount")]
        public long? ReferTemplateCount{ get; set; }

        /// <summary>
        /// 支持的数据源
        /// </summary>
        [JsonProperty("SupportDataSource")]
        public string[] SupportDataSource{ get; set; }

        /// <summary>
        /// 风险面
        /// </summary>
        [JsonProperty("RiskSide")]
        public string RiskSide{ get; set; }

        /// <summary>
        /// 关联模板列表
        /// </summary>
        [JsonProperty("ReferTemplateList")]
        public TemplateInfo[] ReferTemplateList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "ReferTemplateCount", this.ReferTemplateCount);
            this.SetParamArraySimple(map, prefix + "SupportDataSource.", this.SupportDataSource);
            this.SetParamSimple(map, prefix + "RiskSide", this.RiskSide);
            this.SetParamArrayObj(map, prefix + "ReferTemplateList.", this.ReferTemplateList);
        }
    }
}

