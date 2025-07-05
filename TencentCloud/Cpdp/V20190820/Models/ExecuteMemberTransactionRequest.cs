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

    public class ExecuteMemberTransactionRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求类型此接口固定填：MemberTransactionReq
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 银行注册商户号
        /// </summary>
        [JsonProperty("MerchantCode")]
        public string MerchantCode{ get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [JsonProperty("PayChannel")]
        public string PayChannel{ get; set; }

        /// <summary>
        /// 子渠道
        /// </summary>
        [JsonProperty("PayChannelSubId")]
        public long? PayChannelSubId{ get; set; }

        /// <summary>
        /// 转出交易网会员代码
        /// </summary>
        [JsonProperty("OutTransNetMemberCode")]
        public string OutTransNetMemberCode{ get; set; }

        /// <summary>
        /// 转出见证子账户的户名
        /// </summary>
        [JsonProperty("OutSubAccountName")]
        public string OutSubAccountName{ get; set; }

        /// <summary>
        /// 转入见证子账户的户名
        /// </summary>
        [JsonProperty("InSubAccountName")]
        public string InSubAccountName{ get; set; }

        /// <summary>
        /// 转出子账户账号
        /// </summary>
        [JsonProperty("OutSubAccountNumber")]
        public string OutSubAccountNumber{ get; set; }

        /// <summary>
        /// 转入子账户账号
        /// </summary>
        [JsonProperty("InSubAccountNumber")]
        public string InSubAccountNumber{ get; set; }

        /// <summary>
        /// 父账户账号，资金汇总账号
        /// </summary>
        [JsonProperty("BankAccountNumber")]
        public string BankAccountNumber{ get; set; }

        /// <summary>
        /// 货币单位 单位，1：元，2：角，3：分
        /// </summary>
        [JsonProperty("CurrencyUnit")]
        public string CurrencyUnit{ get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("CurrencyAmount")]
        public string CurrencyAmount{ get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 计费签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 交易流水号 
        /// 生成方式：用户短号+日期（6位）+ 随机编号（10位）例如：F088722005120904930798
        /// 短号：F08872  日期： 200512   随机编号：0904930798
        /// </summary>
        [JsonProperty("TransSequenceNumber")]
        public string TransSequenceNumber{ get; set; }

        /// <summary>
        /// 转入交易网会员代码
        /// </summary>
        [JsonProperty("InTransNetMemberCode")]
        public string InTransNetMemberCode{ get; set; }

        /// <summary>
        /// Midas环境标识 release 现网环境 sandbox 沙箱环境
        /// development 开发环境
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 平台短号(银行分配)
        /// </summary>
        [JsonProperty("PlatformShortNumber")]
        public string PlatformShortNumber{ get; set; }

        /// <summary>
        /// 1：下单预支付 
        /// 2：确认并付款
        /// 3：退款
        /// 6：直接支付T+1
        /// 9：直接支付T+0
        /// </summary>
        [JsonProperty("TransType")]
        public string TransType{ get; set; }

        /// <summary>
        /// 交易手续费
        /// </summary>
        [JsonProperty("TransFee")]
        public string TransFee{ get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        [JsonProperty("ReservedMessage")]
        public string ReservedMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "MerchantCode", this.MerchantCode);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamSimple(map, prefix + "PayChannelSubId", this.PayChannelSubId);
            this.SetParamSimple(map, prefix + "OutTransNetMemberCode", this.OutTransNetMemberCode);
            this.SetParamSimple(map, prefix + "OutSubAccountName", this.OutSubAccountName);
            this.SetParamSimple(map, prefix + "InSubAccountName", this.InSubAccountName);
            this.SetParamSimple(map, prefix + "OutSubAccountNumber", this.OutSubAccountNumber);
            this.SetParamSimple(map, prefix + "InSubAccountNumber", this.InSubAccountNumber);
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "CurrencyUnit", this.CurrencyUnit);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "CurrencyAmount", this.CurrencyAmount);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "TransSequenceNumber", this.TransSequenceNumber);
            this.SetParamSimple(map, prefix + "InTransNetMemberCode", this.InTransNetMemberCode);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "PlatformShortNumber", this.PlatformShortNumber);
            this.SetParamSimple(map, prefix + "TransType", this.TransType);
            this.SetParamSimple(map, prefix + "TransFee", this.TransFee);
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
        }
    }
}

