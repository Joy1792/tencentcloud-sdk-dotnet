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

    public class DescribeKafkaConsumerResponse : AbstractModel
    {
        
        /// <summary>
        /// Kafka协议消费是否打开
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// KafkaConsumer 消费时使用的Topic参数
        /// </summary>
        [JsonProperty("TopicID")]
        public string TopicID{ get; set; }

        /// <summary>
        /// 压缩方式[0:NONE；2:SNAPPY；3:LZ4]
        /// </summary>
        [JsonProperty("Compression")]
        public long? Compression{ get; set; }

        /// <summary>
        /// kafka协议消费数据格式
        /// </summary>
        [JsonProperty("ConsumerContent")]
        public KafkaConsumerContent ConsumerContent{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TopicID", this.TopicID);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamObj(map, prefix + "ConsumerContent.", this.ConsumerContent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

