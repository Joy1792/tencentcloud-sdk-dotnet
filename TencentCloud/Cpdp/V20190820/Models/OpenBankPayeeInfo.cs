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

    public class OpenBankPayeeInfo : AbstractModel
    {
        
        /// <summary>
        /// 收款方唯一标识。
        /// 当渠道为TENPAY，付款方式为EBANK_PAYMENT，必填，上送收款方入驻云企付商户ID；
        /// 付款方式为OPENBANK_PAYMENT时，非必填，输入外部收款方的标识ID
        /// 渠道为WECHAT，付款方式为TRANS_TO_CHANGE时，上送微信OPEN_ID；
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 支行名称。
        /// </summary>
        [JsonProperty("BankBranchName")]
        public string BankBranchName{ get; set; }

        /// <summary>
        /// 银行账号。渠道为TENPAY，付款方式为OPENBANK_PAYMENT时必选
        /// </summary>
        [JsonProperty("BankAccountNumber")]
        public string BankAccountNumber{ get; set; }

        /// <summary>
        /// 收款方名称。
        /// 当渠道为TENPAY，付款方式为EBANK_PAYMENT时，上送收款方入驻云企付的商户名称；
        /// 渠道为TENPAY，付款方式为OPENBANK_PAYMENT时必选，上送收款方账户名称；
        /// 渠道为ALIPAY，付款方式为SAFT_ISV时，收款账户标识类型为ALIPAY_LOGON_ID时必传，上送收款方真实姓名。
        /// 渠道为WECHAT，付款方式为TRANS_TO_CHANGE时，上送收款人姓名。
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }

        /// <summary>
        /// 联行号。渠道为TENPAY，付款方式为OPENBANK_PAYMENT时必选
        /// </summary>
        [JsonProperty("BankBranchId")]
        public string BankBranchId{ get; set; }

        /// <summary>
        /// 收款方绑卡序列号。
        /// 当渠道为TENPAY，付款方式为EBANK_PAYMENT时，必填，上送收款方入驻云企付平台时，下发的绑卡序列号；当渠道为ALIPAY，付款方式为SAFT_ISV时，必填，根据收款账户标识类型上送。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }

        /// <summary>
        /// 收款账户标识类型
        /// BANK_ACCOUNT：绑定银行账户
        /// ACCOUNT_BOOK_ID：电子记账本ID
        /// ALIPAY_USER_ID：支付宝的会员ID
        /// ALIPAY_LOGON_ID：支付宝登录号。
        /// 付款方式为SAFT_ISV时，必填。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "BankBranchName", this.BankBranchName);
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
            this.SetParamSimple(map, prefix + "BankBranchId", this.BankBranchId);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
        }
    }
}

