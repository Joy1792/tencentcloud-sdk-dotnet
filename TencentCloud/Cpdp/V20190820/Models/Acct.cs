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

    public class Acct : AbstractModel
    {
        
        /// <summary>
        /// STRING(50)，见证子账户的账号（可重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// STRING(10)，见证子账户的属性（可重复。1: 普通会员子账号; 2: 挂账子账号; 3: 手续费子账号; 4: 利息子账号; 5: 平台担保子账号）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctProperty")]
        public string SubAcctProperty{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码（可重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(150)，见证子账户的名称（可重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctName")]
        public string SubAcctName{ get; set; }

        /// <summary>
        /// STRING(20)，见证子账户可用余额（可重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AcctAvailBal")]
        public string AcctAvailBal{ get; set; }

        /// <summary>
        /// STRING(20)，见证子账户可提现金额（可重复。开户日期或修改日期）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CashAmt")]
        public string CashAmt{ get; set; }

        /// <summary>
        /// STRING(8)，维护日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaintenanceDate")]
        public string MaintenanceDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "SubAcctProperty", this.SubAcctProperty);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "SubAcctName", this.SubAcctName);
            this.SetParamSimple(map, prefix + "AcctAvailBal", this.AcctAvailBal);
            this.SetParamSimple(map, prefix + "CashAmt", this.CashAmt);
            this.SetParamSimple(map, prefix + "MaintenanceDate", this.MaintenanceDate);
        }
    }
}

