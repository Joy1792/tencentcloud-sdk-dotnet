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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTopicPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 更新前Topic名
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 更新后Topic名
        /// </summary>
        [JsonProperty("NewTopicName")]
        public string NewTopicName{ get; set; }

        /// <summary>
        /// Topic权限
        /// </summary>
        [JsonProperty("Privilege")]
        public ulong? Privilege{ get; set; }

        /// <summary>
        /// 代理订阅信息
        /// </summary>
        [JsonProperty("BrokerSubscribe")]
        public BrokerSubscribe BrokerSubscribe{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "NewTopicName", this.NewTopicName);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
            this.SetParamObj(map, prefix + "BrokerSubscribe.", this.BrokerSubscribe);
        }
    }
}

