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

    public class CreateOpenBankOrderRechargeResult : AbstractModel
    {
        
        /// <summary>
        /// 云企付平台订单号。
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 第三方支付平台返回支付订单号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThirdPayOrderId")]
        public string ThirdPayOrderId{ get; set; }

        /// <summary>
        /// 跳转参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public OpenBankRechargeRedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// 外部商户订单号，只能是数字、大小写字母，且在同一个接入平台下唯一。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 充值状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DealStatus")]
        public string DealStatus{ get; set; }

        /// <summary>
        /// 充值返回描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DealMessage")]
        public string DealMessage{ get; set; }

        /// <summary>
        /// PC web端跳转链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PcWebUrl")]
        public string PcWebUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "ThirdPayOrderId", this.ThirdPayOrderId);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "DealMessage", this.DealMessage);
            this.SetParamSimple(map, prefix + "PcWebUrl", this.PcWebUrl);
        }
    }
}

