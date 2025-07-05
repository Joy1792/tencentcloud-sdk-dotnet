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

    public class DescribeDatahubTopicsRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索词
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 本次查询的偏移位置，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 本次返回结果的最大个数，默认为50，最大值为50
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 是否从连接查询topic列表
        /// </summary>
        [JsonProperty("QueryFromConnectResource")]
        public bool? QueryFromConnectResource{ get; set; }

        /// <summary>
        /// 连接的ID
        /// </summary>
        [JsonProperty("ConnectResourceId")]
        public string ConnectResourceId{ get; set; }

        /// <summary>
        /// topic资源表达式
        /// </summary>
        [JsonProperty("TopicRegularExpression")]
        public string TopicRegularExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "QueryFromConnectResource", this.QueryFromConnectResource);
            this.SetParamSimple(map, prefix + "ConnectResourceId", this.ConnectResourceId);
            this.SetParamSimple(map, prefix + "TopicRegularExpression", this.TopicRegularExpression);
        }
    }
}

