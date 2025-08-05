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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// logsetName
        /// - 按照【日志集名称】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// - 通过 [获取日志集列表](https://cloud.tencent.com/document/product/614/58624)获取日志集名称。
        /// logsetId
        /// - 按照【日志集ID】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// - 通过 [获取日志集列表](https://cloud.tencent.com/document/product/614/58624)获取日志集Id。
        /// 
        /// tagKey
        /// - 按照【标签键】进行过滤。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// tag:tagKey
        /// - 按照【标签键值对】进行过滤。tagKey使用具体的标签键进行替换。
        /// - 类型：String
        /// - 必选：否
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页的偏移量，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页单页的限制数目，默认值为20，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

