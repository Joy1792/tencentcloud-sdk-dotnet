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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProxiesRequest : AbstractModel
    {
        
        /// <summary>
        /// （旧参数，请切换到ProxyIds）按照一个或者多个实例ID查询。每次请求的实例的上限为100。参数不支持同时指定InstanceIds和Filters。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤条件。   
        /// 每次请求的Filters的上限为10，Filter.Values的上限为5。参数不支持同时指定InstanceIds和Filters。 
        /// ProjectId - String - 是否必填：否 -（过滤条件）按照项目ID过滤。   
        /// AccessRegion - String - 是否必填：否 - （过滤条件）按照接入地域过滤。    
        /// RealServerRegion - String - 是否必填：否 - （过滤条件）按照源站地域过滤。
        /// GroupId - String - 是否必填：否 - （过滤条件）按照通道组ID过滤。
        /// IPAddressVersion - String - 是否必填：否 - （过滤条件）按照IP版本过滤。
        /// PackageType - String - 是否必填：否 - （过滤条件）按照通道套餐类型过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// （新参数，替代InstanceIds）按照一个或者多个实例ID查询。每次请求的实例的上限为100。参数不支持同时指定InstanceIds和Filters。
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// 标签列表，当存在该字段时，拉取对应标签下的资源列表。
        /// 最多支持5个标签，当存在两个或两个以上的标签时，满足其中任意一个标签时，通道会被拉取出来。
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// 当该字段为1时，仅拉取非通道组的通道，
        /// 当该字段为0时，仅拉取通道组的通道，
        /// 不存在该字段时，拉取所有通道，包括独立通道和通道组通道。
        /// </summary>
        [JsonProperty("Independent")]
        public long? Independent{ get; set; }

        /// <summary>
        /// 输出通道列表的排列顺序。取值范围：
        /// asc：升序排列；
        /// desc：降序排列。
        /// 默认为降序。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 通道列表排序的依据字段。取值范围：
        /// create_time：依据通道的创建时间排序；
        /// proxy_id：依据通道的ID排序；
        /// bandwidth：依据通道带宽上限排序；
        /// concurrent_connections：依据通道并发排序；
        /// 默认按通道创建时间排序。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Independent", this.Independent);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

