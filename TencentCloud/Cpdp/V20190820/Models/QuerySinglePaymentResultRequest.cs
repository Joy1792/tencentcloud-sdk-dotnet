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

    public class QuerySinglePaymentResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 转账类型
        /// </summary>
        [JsonProperty("TransferType")]
        public long? TransferType{ get; set; }

        /// <summary>
        /// 交易流水流水号，唯一
        /// </summary>
        [JsonProperty("TradeSerialNo")]
        public string TradeSerialNo{ get; set; }

        /// <summary>
        /// 订单号，与TradeSerialNo不能同时为空
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "TradeSerialNo", this.TradeSerialNo);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
        }
    }
}

