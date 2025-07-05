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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenBankProfitShareInfo : AbstractModel
    {
        
        /// <summary>
        /// 分润接收方，渠道商户号ID
        /// </summary>
        [JsonProperty("RecvId")]
        public string RecvId{ get; set; }

        /// <summary>
        /// 分润金额，单位分
        /// </summary>
        [JsonProperty("ProfitShareFee")]
        public long? ProfitShareFee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecvId", this.RecvId);
            this.SetParamSimple(map, prefix + "ProfitShareFee", this.ProfitShareFee);
        }
    }
}

