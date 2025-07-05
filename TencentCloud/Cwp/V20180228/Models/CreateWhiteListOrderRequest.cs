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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWhiteListOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 授权类型
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// 授权数量,最小为1 最大99999
        /// </summary>
        [JsonProperty("LicenseNum")]
        public ulong? LicenseNum{ get; set; }

        /// <summary>
        /// 到期时间,最小为1
        /// </summary>
        [JsonProperty("Deadline")]
        public ulong? Deadline{ get; set; }

        /// <summary>
        /// 规则名称,大资产中心:asset_center
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 订单类型, 1 试用 2 赠送 3 体验 4 SSL-证书赠送 5 cvm赠送
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 地域, 1 广州 9新加坡, 默认为 1. 非必要情况不要选9
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 额外参数,json字符串,包含ResourceId 资源ID,LicenseType 授权类型
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "LicenseNum", this.LicenseNum);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
        }
    }
}

