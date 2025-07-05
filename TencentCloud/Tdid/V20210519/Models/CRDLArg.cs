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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CRDLArg : AbstractModel
    {
        
        /// <summary>
        /// CPT ID
        /// </summary>
        [JsonProperty("CPTId")]
        public ulong? CPTId{ get; set; }

        /// <summary>
        /// 签发者 did
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// 声明
        /// </summary>
        [JsonProperty("ClaimJson")]
        public string ClaimJson{ get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 多方签名的用户did
        /// </summary>
        [JsonProperty("Parties")]
        public string[] Parties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CPTId", this.CPTId);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "ClaimJson", this.ClaimJson);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "Parties.", this.Parties);
        }
    }
}

