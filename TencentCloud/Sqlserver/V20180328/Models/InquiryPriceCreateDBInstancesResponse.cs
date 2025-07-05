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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceCreateDBInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// 未打折前价格，其值除以100表示最终的价格。
        /// InstanceChargeType=PREPAID时，单位是"每月"。
        /// InstanceChargeType=POSTPAID时，单位是"每小时"。
        /// 例如10010，在InstanceChargeType=PREPAID情况下，表示每月100.10元。
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public long? OriginalPrice{ get; set; }

        /// <summary>
        /// 实际需要支付的价格，其值除以100表示最终的价格。
        /// InstanceChargeType=PREPAID时，单位是"每月"。
        /// InstanceChargeType=POSTPAID时，单位是"每小时"。
        /// 例如10010，在InstanceChargeType=PREPAID情况下，表示每月100.10元。
        /// </summary>
        [JsonProperty("Price")]
        public long? Price{ get; set; }

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
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

