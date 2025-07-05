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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 置放群组 ID。
        /// </summary>
        [JsonProperty("DeployGroupId")]
        public string DeployGroupId{ get; set; }

        /// <summary>
        /// 置放群组名称。
        /// </summary>
        [JsonProperty("DeployGroupName")]
        public string DeployGroupName{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 置放群组实例配额，表示一个置放群组中可容纳的最大实例数目。
        /// </summary>
        [JsonProperty("Quota")]
        public long? Quota{ get; set; }

        /// <summary>
        /// 置放群组亲和性策略，目前仅支持策略1，即在物理机纬度打散实例的分布。
        /// </summary>
        [JsonProperty("Affinity")]
        public string Affinity{ get; set; }

        /// <summary>
        /// 置放群组亲和性策略1中，同台物理机上同个置放群组实例的限制个数。
        /// </summary>
        [JsonProperty("LimitNum")]
        public long? LimitNum{ get; set; }

        /// <summary>
        /// 置放群组详细信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 置放群组物理机型属性。
        /// </summary>
        [JsonProperty("DevClass")]
        public string DevClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployGroupId", this.DeployGroupId);
            this.SetParamSimple(map, prefix + "DeployGroupName", this.DeployGroupName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Quota", this.Quota);
            this.SetParamSimple(map, prefix + "Affinity", this.Affinity);
            this.SetParamSimple(map, prefix + "LimitNum", this.LimitNum);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DevClass", this.DevClass);
        }
    }
}

