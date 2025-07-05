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

    public class ApplyOpenBankSubMerchantSignOnlineResult : AbstractModel
    {
        
        /// <summary>
        /// 处理状态
        ///   SUCCESS：签约成功
        ///   FAILED：签约失败
        ///   PROCESSING：签约中
        /// </summary>
        [JsonProperty("SignStatus")]
        public string SignStatus{ get; set; }

        /// <summary>
        /// 上传返回描述，例如失败原因等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignMessage")]
        public string SignMessage{ get; set; }

        /// <summary>
        /// 第三方渠道返回信息，见渠道特殊说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnData")]
        public string ExternalReturnData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignStatus", this.SignStatus);
            this.SetParamSimple(map, prefix + "SignMessage", this.SignMessage);
            this.SetParamSimple(map, prefix + "ExternalReturnData", this.ExternalReturnData);
        }
    }
}

