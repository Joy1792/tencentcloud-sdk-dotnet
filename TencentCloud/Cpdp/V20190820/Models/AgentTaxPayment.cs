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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentTaxPayment : AbstractModel
    {
        
        /// <summary>
        /// 主播银行账号
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 主播姓名
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 主播身份证
        /// </summary>
        [JsonProperty("AnchorIDCard")]
        public string AnchorIDCard{ get; set; }

        /// <summary>
        /// 纳税的开始时间，格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 纳税的结束时间，格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 流水金额。以“分”为单位
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// 应缴税款。以“分”为单位
        /// </summary>
        [JsonProperty("Tax")]
        public long? Tax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "AnchorIDCard", this.AnchorIDCard);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
        }
    }
}

