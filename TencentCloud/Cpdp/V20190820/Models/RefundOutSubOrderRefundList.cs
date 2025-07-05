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

    public class RefundOutSubOrderRefundList : AbstractModel
    {
        
        /// <summary>
        /// 平台应退金额
        /// </summary>
        [JsonProperty("PlatformRefundAmt")]
        public long? PlatformRefundAmt{ get; set; }

        /// <summary>
        /// 子订单退款金额
        /// </summary>
        [JsonProperty("RefundAmt")]
        public long? RefundAmt{ get; set; }

        /// <summary>
        /// 商家应退金额
        /// </summary>
        [JsonProperty("SubMchRefundAmt")]
        public long? SubMchRefundAmt{ get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonProperty("SubOutTradeNo")]
        public string SubOutTradeNo{ get; set; }

        /// <summary>
        /// 子退款单号，调用方需要保证 全局唯一性
        /// </summary>
        [JsonProperty("SubRefundId")]
        public string SubRefundId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformRefundAmt", this.PlatformRefundAmt);
            this.SetParamSimple(map, prefix + "RefundAmt", this.RefundAmt);
            this.SetParamSimple(map, prefix + "SubMchRefundAmt", this.SubMchRefundAmt);
            this.SetParamSimple(map, prefix + "SubOutTradeNo", this.SubOutTradeNo);
            this.SetParamSimple(map, prefix + "SubRefundId", this.SubRefundId);
        }
    }
}

