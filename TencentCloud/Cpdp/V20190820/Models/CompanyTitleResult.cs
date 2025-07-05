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

    public class CompanyTitleResult : AbstractModel
    {
        
        /// <summary>
        /// 公司银行账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyBankAccount")]
        public string CompanyBankAccount{ get; set; }

        /// <summary>
        /// 公司地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }

        /// <summary>
        /// 公司税号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyTaxpayerNum")]
        public string CompanyTaxpayerNum{ get; set; }

        /// <summary>
        /// 公司名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 公司银行名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyBankName")]
        public string CompanyBankName{ get; set; }

        /// <summary>
        /// 公司电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompanyPhone")]
        public string CompanyPhone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyBankAccount", this.CompanyBankAccount);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
            this.SetParamSimple(map, prefix + "CompanyTaxpayerNum", this.CompanyTaxpayerNum);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyBankName", this.CompanyBankName);
            this.SetParamSimple(map, prefix + "CompanyPhone", this.CompanyPhone);
        }
    }
}

