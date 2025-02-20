/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CodePack : AbstractModel
    {
        
        /// <summary>
        /// 码id
        /// </summary>
        [JsonProperty("PackId")]
        public string PackId{ get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [JsonProperty("CorpId")]
        public long? CorpId{ get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 制码状态 init: 初始化, pending: 执行中, done: 完成, error: 失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 执行日志
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// 码数
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// 防伪码长度
        /// </summary>
        [JsonProperty("CodeLength")]
        public long? CodeLength{ get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [JsonProperty("CodeType")]
        public string CodeType{ get; set; }

        /// <summary>
        /// 是否暗码
        /// </summary>
        [JsonProperty("Cipher")]
        public long? Cipher{ get; set; }

        /// <summary>
        /// [弃用] 文字码地址，通过另一个接口查
        /// </summary>
        [JsonProperty("TextUrl")]
        public string TextUrl{ get; set; }

        /// <summary>
        /// [弃用] 二维码地址，通过另一个接口查
        /// </summary>
        [JsonProperty("PackUrl")]
        public string PackUrl{ get; set; }

        /// <summary>
        /// 商户名
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 码规则类型 0: 默认, 1: 自定义
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 自定义码规则ID
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 码包类型 0: 普通码包 1: 层级码包
        /// </summary>
        [JsonProperty("PackType")]
        public long? PackType{ get; set; }

        /// <summary>
        /// 生码层级
        /// </summary>
        [JsonProperty("PackLevel")]
        public ulong? PackLevel{ get; set; }

        /// <summary>
        /// 层级码配置
        /// </summary>
        [JsonProperty("PackSpec")]
        public PackSpec[] PackSpec{ get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("ProductSpecification")]
        public string ProductSpecification{ get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 码关系是否预关联
        /// 0:否, 1:是
        /// </summary>
        [JsonProperty("RelateType")]
        public long? RelateType{ get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("SceneCode")]
        public long? SceneCode{ get; set; }

        /// <summary>
        /// 码规则
        /// </summary>
        [JsonProperty("CodeRule")]
        public string CodeRule{ get; set; }

        /// <summary>
        /// 已使用码数
        /// </summary>
        [JsonProperty("UsedAmount")]
        public long? UsedAmount{ get; set; }

        /// <summary>
        /// 开始流水号
        /// </summary>
        [JsonProperty("SerialStart")]
        public ulong? SerialStart{ get; set; }

        /// <summary>
        /// 结束流水号
        /// </summary>
        [JsonProperty("SerialEnd")]
        public ulong? SerialEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackId", this.PackId);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CodeLength", this.CodeLength);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamSimple(map, prefix + "Cipher", this.Cipher);
            this.SetParamSimple(map, prefix + "TextUrl", this.TextUrl);
            this.SetParamSimple(map, prefix + "PackUrl", this.PackUrl);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamSimple(map, prefix + "PackType", this.PackType);
            this.SetParamSimple(map, prefix + "PackLevel", this.PackLevel);
            this.SetParamArrayObj(map, prefix + "PackSpec.", this.PackSpec);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductSpecification", this.ProductSpecification);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "RelateType", this.RelateType);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "CodeRule", this.CodeRule);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "SerialStart", this.SerialStart);
            this.SetParamSimple(map, prefix + "SerialEnd", this.SerialEnd);
        }
    }
}

