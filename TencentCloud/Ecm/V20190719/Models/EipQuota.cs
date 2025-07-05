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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EipQuota : AbstractModel
    {
        
        /// <summary>
        /// 配额名称，取值范围：
        /// TOTAL_EIP_QUOTA：用户当前地域下EIP的配额数；
        /// DAILY_EIP_APPLY：用户当前地域下今日申购次数；
        /// DAILY_PUBLIC_IP_ASSIGN：用户当前地域下，重新分配公网 IP次数。
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// 当前数量
        /// </summary>
        [JsonProperty("QuotaCurrent")]
        public ulong? QuotaCurrent{ get; set; }

        /// <summary>
        /// 配额数量
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public ulong? QuotaLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaCurrent", this.QuotaCurrent);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
        }
    }
}

