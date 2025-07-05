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

    public class CloudExternalChannelData : AbstractModel
    {
        
        /// <summary>
        /// 第三方渠道数据名。
        /// PAYMENT_ORDER_EXTERNAL_REQUEST_DATA: 支付下单请求数据
        /// PAYMENT_ORDER_EXTERNAL_RETURN_DATA: 支付下单返回数据
        /// PAYMENT_ORDER_EXTERNAL_NOTIFY_DATA: 支付通知数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalChannelDataName")]
        public string ExternalChannelDataName{ get; set; }

        /// <summary>
        /// 第三方渠道数据值。
        /// 当ExternalChannelDataType=PAYMENT时，反序列化格式请参考[ExternalChannelPaymentDataValue](https://dev.tke.midas.qq.com/juxin-doc-next/apidocs/external-channel-data/QueryExternalChannelData.html#externalchannelpaymentdatavalue)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalChannelDataValue")]
        public string ExternalChannelDataValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalChannelDataName", this.ExternalChannelDataName);
            this.SetParamSimple(map, prefix + "ExternalChannelDataValue", this.ExternalChannelDataValue);
        }
    }
}

