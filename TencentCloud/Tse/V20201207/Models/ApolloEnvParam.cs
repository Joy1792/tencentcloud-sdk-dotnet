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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApolloEnvParam : AbstractModel
    {
        
        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 环境内引擎的节点规格 ID
        /// -1C2G
        /// -2C4G
        /// 兼容原spec-xxxxxx形式的规格ID
        /// </summary>
        [JsonProperty("EngineResourceSpec")]
        public string EngineResourceSpec{ get; set; }

        /// <summary>
        /// 环境内引擎的节点数量
        /// </summary>
        [JsonProperty("EngineNodeNum")]
        public long? EngineNodeNum{ get; set; }

        /// <summary>
        /// 配置存储空间大小，以GB为单位
        /// </summary>
        [JsonProperty("StorageCapacity")]
        public long? StorageCapacity{ get; set; }

        /// <summary>
        /// VPC ID。在 VPC 的子网内分配一个 IP 作为 ConfigServer 的访问地址
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID。在 VPC 的子网内分配一个 IP 作为 ConfigServer 的访问地址
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [JsonProperty("EnvDesc")]
        public string EnvDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EngineResourceSpec", this.EngineResourceSpec);
            this.SetParamSimple(map, prefix + "EngineNodeNum", this.EngineNodeNum);
            this.SetParamSimple(map, prefix + "StorageCapacity", this.StorageCapacity);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "EnvDesc", this.EnvDesc);
        }
    }
}

