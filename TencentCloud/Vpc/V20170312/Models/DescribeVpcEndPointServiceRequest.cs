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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVpcEndPointServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。不支持同时传入参数 EndPointServiceIds and Filters。
        /// <li> service-id - String - （过滤条件）终端节点服务唯一ID。</li>
        /// <li>service-name - String - （过滤条件）终端节点实例名称。</li>
        /// <li>service-instance-id - String - （过滤条件）后端服务的唯一ID，比如lb-xxx。</li>
        /// <li>service-type - String - （过滤条件）后端PAAS服务类型，CLB,CDB,CRS，不填默认查询类型为CLB。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单页返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 终端节点服务ID。不支持同时传入参数 EndPointServiceIds and Filters。
        /// </summary>
        [JsonProperty("EndPointServiceIds")]
        public string[] EndPointServiceIds{ get; set; }

        /// <summary>
        /// <li>不支持同时传入参数 Filters 。</li> <li>列出授权给当前账号的终端节点服务信息。可以配合EndPointServiceIds参数进行过滤，哪些终端节点服务授权了该账户。</li>
        /// </summary>
        [JsonProperty("IsListAuthorizedEndPointService")]
        public bool? IsListAuthorizedEndPointService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "EndPointServiceIds.", this.EndPointServiceIds);
            this.SetParamSimple(map, prefix + "IsListAuthorizedEndPointService", this.IsListAuthorizedEndPointService);
        }
    }
}

