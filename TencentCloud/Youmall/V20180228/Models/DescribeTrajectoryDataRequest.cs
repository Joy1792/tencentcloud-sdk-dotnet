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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrajectoryDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 开始日期，格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 结束日期，格式yyyy-MM-dd
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 限制返回数据的最大条数，最大 400（负数代为 400）
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 顾客性别顾虑，0是男，1是女，其它代表不分性别
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
        }
    }
}

