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

namespace TencentCloud.Tbm.V20180129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBrandPosCommentsRequest : AbstractModel
    {
        
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonProperty("BrandId")]
        public string BrandId{ get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 查询条数上限，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 查询偏移，从0开始
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BrandId", this.BrandId);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

