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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComputeEnvsRequest : AbstractModel
    {
        
        /// <summary>
        /// 计算环境ID列表，与Filters参数不能同时指定。最大数量上限100。
        /// </summary>
        [JsonProperty("EnvIds")]
        public string[] EnvIds{ get; set; }

        /// <summary>
        /// 过滤条件<li> zone - String - 是否必填：否 -（过滤条件）按照可用区过滤，可用区通过调用接口 [DescribeZones](https://cloud.tencent.com/document/api/213/15707)获取。</li><li> env-id - String - 是否必填：否 -（过滤条件）按照计算环境ID过滤。</li><li> env-name - String - 是否必填：否 -（过滤条件）按照计算环境名称过滤。</li><li> resource-type - String - 是否必填：否 -（过滤条件）按照计算资源类型过滤，取值CVM或者CPM(黑石)。</li><li> tag-key - String - 是否必填：否 -（过滤条件）按照标签键进行过滤。</li><li>tag-value - String - 是否必填：否 -（过滤条件）按照标签值进行过滤。</li><li>tag:tag-key - String - 是否必填：否 -（过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。</li>与EnvIds参数不能同时指定。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认值20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EnvIds.", this.EnvIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

