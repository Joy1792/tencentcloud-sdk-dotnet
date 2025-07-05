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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTopWafDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 攻击类型统计
        /// </summary>
        [JsonProperty("TopTypeData")]
        public ScdnTypeData[] TopTypeData{ get; set; }

        /// <summary>
        /// IP统计
        /// </summary>
        [JsonProperty("TopIpData")]
        public ScdnTopData[] TopIpData{ get; set; }

        /// <summary>
        /// URL统计
        /// </summary>
        [JsonProperty("TopUrlData")]
        public ScdnTopUrlData[] TopUrlData{ get; set; }

        /// <summary>
        /// 域名统计
        /// </summary>
        [JsonProperty("TopDomainData")]
        public ScdnTopDomainData[] TopDomainData{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "TopTypeData.", this.TopTypeData);
            this.SetParamArrayObj(map, prefix + "TopIpData.", this.TopIpData);
            this.SetParamArrayObj(map, prefix + "TopUrlData.", this.TopUrlData);
            this.SetParamArrayObj(map, prefix + "TopDomainData.", this.TopDomainData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

