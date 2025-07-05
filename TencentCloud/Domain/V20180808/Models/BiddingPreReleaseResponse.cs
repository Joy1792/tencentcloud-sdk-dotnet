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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BiddingPreReleaseResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否需要额外支付
        /// true: 需要额外支付
        /// false: 不需要额外支付
        /// </summary>
        [JsonProperty("IsNeedPay")]
        public bool? IsNeedPay{ get; set; }

        /// <summary>
        /// 计费请求参数，以类Json字符串的形式进行返回。json字符串前有一个">"特定标识符号，去掉标识符的字符串可用于计费下单
        /// </summary>
        [JsonProperty("BillingParam")]
        public string BillingParam{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsNeedPay", this.IsNeedPay);
            this.SetParamSimple(map, prefix + "BillingParam", this.BillingParam);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

