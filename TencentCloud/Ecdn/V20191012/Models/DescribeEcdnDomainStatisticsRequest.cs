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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEcdnDomainStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间，如：2019-12-13 00:00:00。
        /// 起止时间不超过90天。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，如：2019-12-13 23:59:59。
        /// 起止时间不超过90天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 统计指标名称:
        /// flux：流量，单位为 byte
        /// bandwidth：带宽，单位为 bps
        /// request：请求数，单位为 次
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// 指定查询域名列表
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 指定要查询的项目 ID，[前往查看项目 ID](https://console.cloud.tencent.com/project)
        /// 未填充域名情况下，指定项目查询，若填充了具体域名信息，以域名为主
        /// </summary>
        [JsonProperty("Projects")]
        public long?[] Projects{ get; set; }

        /// <summary>
        /// 列表分页起始地址，默认0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 列表分页记录条数，默认1000，最大3000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 统计区域:
        /// mainland: 境内
        /// oversea: 境外
        /// global: 全部
        /// 默认 global
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "Projects.", this.Projects);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

