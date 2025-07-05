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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudBaseBuildServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// build类型,枚举值有: cloudbaserun, framework-ci
        /// </summary>
        [JsonProperty("CIBusiness")]
        public string CIBusiness{ get; set; }

        /// <summary>
        /// 服务版本
        /// </summary>
        [JsonProperty("ServiceVersion")]
        public string ServiceVersion{ get; set; }

        /// <summary>
        /// 文件后缀
        /// </summary>
        [JsonProperty("Suffix")]
        public string Suffix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "CIBusiness", this.CIBusiness);
            this.SetParamSimple(map, prefix + "ServiceVersion", this.ServiceVersion);
            this.SetParamSimple(map, prefix + "Suffix", this.Suffix);
        }
    }
}

