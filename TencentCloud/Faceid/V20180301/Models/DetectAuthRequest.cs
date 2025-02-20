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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectAuthRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务流程ID。
        /// - 用于细分客户使用场景, 可为业务配置不同的业务流程。
        /// - 申请开通服务后，登录腾讯云[慧眼人脸核身控制](https://console.cloud.tencent.com/faceid)进行创建，审核通过后即可调用。
        /// - 如有疑问，请添加[腾讯云人脸核身小助手](https://cloud.tencent.com/document/product/1007/56130)进行咨询。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 本接口不需要传递此参数。
        /// </summary>
        [JsonProperty("TerminalType")]
        public string TerminalType{ get; set; }

        /// <summary>
        /// 验证人的身份证号码。
        /// - 是否必传基于[控制台](https://console.cloud.tencent.com/faceid/access)申请业务流程时配置的提示。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 验证人的姓名。
        /// - 是否必传基于[控制台](https://console.cloud.tencent.com/faceid/access)申请业务流程时配置的提示。
        /// - 最长长度32位。中文请使用UTF-8编码。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 认证结束后重定向的回调链接地址。
        /// - 最长长度1024位。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 透传字段，在获取验证结果时返回。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 用于人脸比对的图像数据，使用base64编码。
        /// - Base64编码后的图片数据大小不超过3M。
        /// - 仅支持jpg、png格式。
        /// - 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// 意愿核身（朗读模式）使用的文案。
        /// - 若未使用意愿核身（朗读模式），则该字段无需传入。
        /// - 最长可接受120的字符串长度。
        /// </summary>
        [JsonProperty("IntentionVerifyText")]
        public string IntentionVerifyText{ get; set; }

        /// <summary>
        /// 意愿核身（语音播报+语音回答模式）使用的文案。
        /// - 包括：系统语音播报的文本、需要核验的标准文本。
        /// - 问答模式支持1-10轮（不超过10轮）的意愿确认。
        /// </summary>
        [JsonProperty("IntentionQuestions")]
        public IntentionQuestion[] IntentionQuestions{ get; set; }

        /// <summary>
        /// 意愿核身（点头确认模式）使用的文案。
        /// - 若未使用意愿核身（点头确认模式），则该字段无需传入。
        /// - 点头确认模式支持1-10轮（不超过10轮）的意愿确认。
        /// </summary>
        [JsonProperty("IntentionActions")]
        public IntentionActionConfig[] IntentionActions{ get; set; }

        /// <summary>
        /// 意愿核身流程配置。
        /// </summary>
        [JsonProperty("Config")]
        public RuleIdConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "TerminalType", this.TerminalType);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "IntentionVerifyText", this.IntentionVerifyText);
            this.SetParamArrayObj(map, prefix + "IntentionQuestions.", this.IntentionQuestions);
            this.SetParamArrayObj(map, prefix + "IntentionActions.", this.IntentionActions);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

