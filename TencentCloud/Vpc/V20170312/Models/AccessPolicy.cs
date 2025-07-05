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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessPolicy : AbstractModel
    {
        
        /// <summary>
        /// 目的CIDR
        /// </summary>
        [JsonProperty("TargetCidr")]
        public string TargetCidr{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("VpnGatewayIdSslAccessPolicyId")]
        public string VpnGatewayIdSslAccessPolicyId{ get; set; }

        /// <summary>
        /// 是否对所有用户都生效。1 生效 0不生效
        /// </summary>
        [JsonProperty("ForAllClient")]
        public ulong? ForAllClient{ get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        [JsonProperty("UserGroupIds")]
        public string[] UserGroupIds{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetCidr", this.TargetCidr);
            this.SetParamSimple(map, prefix + "VpnGatewayIdSslAccessPolicyId", this.VpnGatewayIdSslAccessPolicyId);
            this.SetParamSimple(map, prefix + "ForAllClient", this.ForAllClient);
            this.SetParamArraySimple(map, prefix + "UserGroupIds.", this.UserGroupIds);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

