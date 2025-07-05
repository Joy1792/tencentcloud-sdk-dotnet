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

    public class QueryExchangerateData : AbstractModel
    {
        
        /// <summary>
        /// 汇率
        /// </summary>
        [JsonProperty("Rate")]
        public string Rate{ get; set; }

        /// <summary>
        /// 源币种
        /// </summary>
        [JsonProperty("SourceCurrency")]
        public string SourceCurrency{ get; set; }

        /// <summary>
        /// 目的币种
        /// </summary>
        [JsonProperty("TargetCurrency")]
        public string TargetCurrency{ get; set; }

        /// <summary>
        /// 汇率时间
        /// </summary>
        [JsonProperty("RateTime")]
        public string RateTime{ get; set; }

        /// <summary>
        /// 基准币种
        /// </summary>
        [JsonProperty("BaseCurrency")]
        public string BaseCurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "SourceCurrency", this.SourceCurrency);
            this.SetParamSimple(map, prefix + "TargetCurrency", this.TargetCurrency);
            this.SetParamSimple(map, prefix + "RateTime", this.RateTime);
            this.SetParamSimple(map, prefix + "BaseCurrency", this.BaseCurrency);
        }
    }
}

