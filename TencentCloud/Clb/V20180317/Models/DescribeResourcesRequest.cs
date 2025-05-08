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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回可用区资源列表数目，默认20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 返回可用区资源列表起始偏移量，默认0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 查询可用区资源列表条件，详细的过滤条件如下：
        /// - master-zone
        /// 按照【地域可用区】进行过滤，例如：ap-guangzhou-2。
        /// 类型：String
        /// 必选：否
        /// - ip-version
        /// 按照【IP 类型】进行过滤，例如：IPv4。
        /// 类型：String
        /// 必选：否
        /// 可选项：IPv4、IPv6、IPv6_Nat
        /// - isp
        /// 按照【ISP 类型】进行过滤，例如：BGP。
        /// 类型：String
        /// 必选：否
        /// 可选项：BGP、CMCC（中国移动）、CUCC（中国联通）、CTCC（中国电信）、BGP_PRO、INTERNAL（内网）
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

