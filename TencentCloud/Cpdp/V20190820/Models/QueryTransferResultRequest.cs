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

    public class QueryTransferResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 申请商户号的appid或者商户号绑定的appid
        /// </summary>
        [JsonProperty("MerchantAppId")]
        public string MerchantAppId{ get; set; }

        /// <summary>
        /// 1、 微信企业付款 
        /// 2、 支付宝转账 
        /// 3、 平安银企直联代发转账
        /// </summary>
        [JsonProperty("TransferType")]
        public long? TransferType{ get; set; }

        /// <summary>
        /// 交易流水流水号（与 OrderId 不能同时为空）
        /// </summary>
        [JsonProperty("TradeSerialNo")]
        public string TradeSerialNo{ get; set; }

        /// <summary>
        /// 订单号（与 TradeSerialNo 不能同时为空）
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "MerchantAppId", this.MerchantAppId);
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "TradeSerialNo", this.TradeSerialNo);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

