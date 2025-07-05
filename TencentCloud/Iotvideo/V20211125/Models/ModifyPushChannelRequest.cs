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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPushChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 推送类型。ckafka：消息队列；forward：http/https推送
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 第三方推送地址
        /// </summary>
        [JsonProperty("ForwardAddress")]
        public string ForwardAddress{ get; set; }

        /// <summary>
        /// 第三方推送密钥，不填写则不生成签名。
        /// </summary>
        [JsonProperty("ForwardKey")]
        public string ForwardKey{ get; set; }

        /// <summary>
        /// ckafka地域
        /// </summary>
        [JsonProperty("CKafkaRegion")]
        public string CKafkaRegion{ get; set; }

        /// <summary>
        /// ckafka实例
        /// </summary>
        [JsonProperty("CKafkaInstance")]
        public string CKafkaInstance{ get; set; }

        /// <summary>
        /// ckafka订阅主题
        /// </summary>
        [JsonProperty("CKafkaTopic")]
        public string CKafkaTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ForwardAddress", this.ForwardAddress);
            this.SetParamSimple(map, prefix + "ForwardKey", this.ForwardKey);
            this.SetParamSimple(map, prefix + "CKafkaRegion", this.CKafkaRegion);
            this.SetParamSimple(map, prefix + "CKafkaInstance", this.CKafkaInstance);
            this.SetParamSimple(map, prefix + "CKafkaTopic", this.CKafkaTopic);
        }
    }
}

