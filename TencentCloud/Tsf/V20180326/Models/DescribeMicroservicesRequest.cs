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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMicroservicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 搜索字段
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序类型
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页个数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 状态过滤，online、offline、single_online
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// IdList
        /// </summary>
        [JsonProperty("MicroserviceIdList")]
        public string[] MicroserviceIdList{ get; set; }

        /// <summary>
        /// 搜索的服务名列表
        /// </summary>
        [JsonProperty("MicroserviceNameList")]
        public string[] MicroserviceNameList{ get; set; }

        /// <summary>
        /// 注册中心实例id
        /// </summary>
        [JsonProperty("ConfigCenterInstanceId")]
        public string ConfigCenterInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "MicroserviceIdList.", this.MicroserviceIdList);
            this.SetParamArraySimple(map, prefix + "MicroserviceNameList.", this.MicroserviceNameList);
            this.SetParamSimple(map, prefix + "ConfigCenterInstanceId", this.ConfigCenterInstanceId);
        }
    }
}

