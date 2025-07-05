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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// zone      String      是否必填：否     （过滤条件）按照可用区英文标识符过滤。
        /// zone-name      String      是否必填：否     （过滤条件）按照可用区中文名过滤,支持模糊匹配。
        /// module-id      String      是否必填：否     （过滤条件）按照模块ID过滤。
        /// instance-id      String      是否必填：否      （过滤条件）按照实例ID过滤。
        /// instance-name      String      是否必填：否      （过滤条件）按照实例名称过滤,支持模糊匹配。
        /// ip-address      String      是否必填：否      （过滤条件）按照实例的内网/公网IP过滤。
        /// instance-uuid   string 是否必填：否 （过滤条件）按照uuid过滤实例列表。
        /// instance-state  string  是否必填：否 （过滤条件）按照实例状态更新实例列表。
        /// internet-service-provider      String      是否必填：否      （过滤条件）按照实例公网IP所属的运营商进行过滤。
        /// tag-key      String      是否必填：否      （过滤条件）按照标签键进行过滤。
        /// tag:tag-key      String      是否必填：否      （过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。
        /// instance-family      String      是否必填：否      （过滤条件）按照机型family过滤。
        /// module-name      String      是否必填：否      （过滤条件）按照模块名称过滤,支持模糊匹配。
        /// image-id      String      是否必填：否      （过滤条件）按照实例的镜像ID过滤。
        /// vpc-id String      是否必填：否      （过滤条件）按照实例的vpc id过滤。
        /// subnet-id String      是否必填：否      （过滤条件）按照实例的subnet id过滤。
        /// 
        /// 若不传Filters参数则表示查询所有相关的实例信息。
        /// 单次请求的Filter.Values的上限为5。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20(如果查询结果数目大于等于20)，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 指定排序字段。目前支持的可选值如下
        /// timestamp 按实例创建时间排序。
        /// 注意：目前仅支持按创建时间排序，后续可能会有扩展。
        /// 如果不传，默认按实例创建时间排序
        /// </summary>
        [JsonProperty("OrderByField")]
        public string OrderByField{ get; set; }

        /// <summary>
        /// 指定排序是降序还是升序。0表示降序； 1表示升序。如果不传默认为降序
        /// </summary>
        [JsonProperty("OrderDirection")]
        public long? OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByField", this.OrderByField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

