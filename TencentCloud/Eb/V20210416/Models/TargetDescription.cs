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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetDescription : AbstractModel
    {
        
        /// <summary>
        /// QCS资源六段式，更多参考 [资源六段式](https://cloud.tencent.com/document/product/598/10606)；scf资源六段式示例[qcs::scf:ap-guangzhou:uin/123:namespace/test(函数命名空间)/function/test(函数名)/$LATEST(函数版本)] amp资源六段式示例[qcs::eb-amp:ap-guangzhou:uin/123:] ckafka资源六段式示例[qcs::ckafka:ap-guangzhou:uin/123:ckafkaId/uin/123/ckafka-123(ckafka实例Id)] cls资源六段式示例[qcs::cls:ap-guangzhou:uin/123:topic/122332442(topicId)] es资源六段式示例[qcs::es:ap-guangzhou:appid/123/uin/456:instance/es-7cplmhsd(es实例Id)]
        /// </summary>
        [JsonProperty("ResourceDescription")]
        public string ResourceDescription{ get; set; }

        /// <summary>
        /// 云函数参数
        /// </summary>
        [JsonProperty("SCFParams")]
        public SCFParams SCFParams{ get; set; }

        /// <summary>
        /// Ckafka参数
        /// </summary>
        [JsonProperty("CkafkaTargetParams")]
        public CkafkaTargetParams CkafkaTargetParams{ get; set; }

        /// <summary>
        /// ElasticSearch参数
        /// </summary>
        [JsonProperty("ESTargetParams")]
        public ESTargetParams ESTargetParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceDescription", this.ResourceDescription);
            this.SetParamObj(map, prefix + "SCFParams.", this.SCFParams);
            this.SetParamObj(map, prefix + "CkafkaTargetParams.", this.CkafkaTargetParams);
            this.SetParamObj(map, prefix + "ESTargetParams.", this.ESTargetParams);
        }
    }
}

