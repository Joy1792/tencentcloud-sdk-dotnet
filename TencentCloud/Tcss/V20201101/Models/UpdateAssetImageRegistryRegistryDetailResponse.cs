/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAssetImageRegistryRegistryDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 连接错误信息
        /// </summary>
        [JsonProperty("HealthCheckErr")]
        public string HealthCheckErr{ get; set; }

        /// <summary>
        /// 名称错误信息
        /// </summary>
        [JsonProperty("NameRepeatErr")]
        public string NameRepeatErr{ get; set; }

        /// <summary>
        /// 仓库唯一id
        /// </summary>
        [JsonProperty("RegistryId")]
        public long? RegistryId{ get; set; }

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
            this.SetParamSimple(map, prefix + "HealthCheckErr", this.HealthCheckErr);
            this.SetParamSimple(map, prefix + "NameRepeatErr", this.NameRepeatErr);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

