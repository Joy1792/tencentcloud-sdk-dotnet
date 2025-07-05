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

    public class MigrateOrderRefundResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求成功状态
        /// </summary>
        [JsonProperty("IsSuccess")]
        public bool? IsSuccess{ get; set; }

        /// <summary>
        /// 退款流水号
        /// </summary>
        [JsonProperty("TradeSerialNo")]
        public string TradeSerialNo{ get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [JsonProperty("TradeMsg")]
        public string TradeMsg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSuccess", this.IsSuccess);
            this.SetParamSimple(map, prefix + "TradeSerialNo", this.TradeSerialNo);
            this.SetParamSimple(map, prefix + "TradeMsg", this.TradeMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

