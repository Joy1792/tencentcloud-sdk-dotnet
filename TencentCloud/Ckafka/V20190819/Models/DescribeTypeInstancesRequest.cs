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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTypeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// （过滤条件）按照实例ID过滤
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// （过滤条件）按照实例名称过滤，支持模糊查询
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// （过滤条件）实例的状态。0：创建中，1：运行中，2：删除中，不填默认返回全部
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 偏移量，不填默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，不填则默认10，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 匹配标签key值。
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
        }
    }
}

