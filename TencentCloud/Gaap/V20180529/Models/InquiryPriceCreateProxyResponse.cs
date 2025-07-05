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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateProxyResponse : AbstractModel
    {
        
        /// <summary>
        /// 通道基础费用价格，单位：元/天。
        /// </summary>
        [JsonProperty("ProxyDailyPrice")]
        public float? ProxyDailyPrice{ get; set; }

        /// <summary>
        /// 通道带宽费用梯度价格。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthUnitPrice")]
        public BandwidthPriceGradient[] BandwidthUnitPrice{ get; set; }

        /// <summary>
        /// 通道基础费用折扣价格，单位：元/天。
        /// </summary>
        [JsonProperty("DiscountProxyDailyPrice")]
        public float? DiscountProxyDailyPrice{ get; set; }

        /// <summary>
        /// 价格使用的货币，支持人民币，美元等。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 通道的流量费用价格，单位: 元/GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowUnitPrice")]
        public float? FlowUnitPrice{ get; set; }

        /// <summary>
        /// 通道的流量费用折扣价格，单位:元/GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountFlowUnitPrice")]
        public float? DiscountFlowUnitPrice{ get; set; }

        /// <summary>
        /// 精品BGP的带宽费用价格，单位: 元/Mbps/天
        /// </summary>
        [JsonProperty("Cn2BandwidthPrice")]
        public float? Cn2BandwidthPrice{ get; set; }

        /// <summary>
        /// 精品BGP的折后带宽费用价格，单位: 元/Mbps/天
        /// </summary>
        [JsonProperty("Cn2BandwidthPriceWithDiscount")]
        public float? Cn2BandwidthPriceWithDiscount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProxyDailyPrice", this.ProxyDailyPrice);
            this.SetParamArrayObj(map, prefix + "BandwidthUnitPrice.", this.BandwidthUnitPrice);
            this.SetParamSimple(map, prefix + "DiscountProxyDailyPrice", this.DiscountProxyDailyPrice);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "FlowUnitPrice", this.FlowUnitPrice);
            this.SetParamSimple(map, prefix + "DiscountFlowUnitPrice", this.DiscountFlowUnitPrice);
            this.SetParamSimple(map, prefix + "Cn2BandwidthPrice", this.Cn2BandwidthPrice);
            this.SetParamSimple(map, prefix + "Cn2BandwidthPriceWithDiscount", this.Cn2BandwidthPriceWithDiscount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

