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

namespace TencentCloud.Eis.V20210601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListRuntimesMCRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境运行类型：0:运行时类型、1:api类型
        /// </summary>
        [JsonProperty("RuntimeClass")]
        public long? RuntimeClass{ get; set; }

        /// <summary>
        /// 计划类型：0-pro 1-lite
        /// </summary>
        [JsonProperty("PlanType")]
        public long? PlanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeClass", this.RuntimeClass);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
        }
    }
}

