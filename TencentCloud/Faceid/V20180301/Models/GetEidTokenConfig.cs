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

    public class GetEidTokenConfig : AbstractModel
    {
        
        /// <summary>
        /// 姓名身份证输入方式。
        /// 1：传身份证正反面OCR   
        /// 2：传身份证正面OCR  
        /// 3：用户手动输入  
        /// 4：客户后台传入  
        /// 默认1
        /// 注：使用OCR时仅支持用户修改结果中的姓名
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 是否使用意愿核身，默认不使用。注意：如开启使用，则计费标签按【意愿核身】计费标签计价；如不开启，则计费标签按【E证通】计费标签计价，价格详见：[价格说明](https://cloud.tencent.com/document/product/1007/56804)。
        /// </summary>
        [JsonProperty("UseIntentionVerify")]
        public bool? UseIntentionVerify{ get; set; }

        /// <summary>
        /// 意愿核身模式。枚举值：1( 语音朗读模式)，2（语音问答模式） ，3（点头确认模式）。默认值为1。
        /// </summary>
        [JsonProperty("IntentionMode")]
        public string IntentionMode{ get; set; }

        /// <summary>
        /// 意愿核身朗读模式使用的文案，若未使用意愿核身朗读功能，该字段无需传入。默认为空，最长可接受120的字符串长度。
        /// </summary>
        [JsonProperty("IntentionVerifyText")]
        public string IntentionVerifyText{ get; set; }

        /// <summary>
        /// 意愿核身问答模式的配置列表。当前仅支持一个问答。
        /// </summary>
        [JsonProperty("IntentionQuestions")]
        public IntentionQuestion[] IntentionQuestions{ get; set; }

        /// <summary>
        /// 意愿核身（点头确认模式）使用的文案，若未使用意愿核身（点头确认模式），则该字段无需传入。默认为空，最长可接受150的字符串长度。
        /// </summary>
        [JsonProperty("IntentionActions")]
        public IntentionActionConfig[] IntentionActions{ get; set; }

        /// <summary>
        /// 意愿核身过程中识别用户的回答意图，开启后除了IntentionQuestions的Answers列表中的标准回答会通过，近似意图的回答也会通过，默认开启。
        /// </summary>
        [JsonProperty("IntentionRecognition")]
        public bool? IntentionRecognition{ get; set; }

        /// <summary>
        /// 是否支持港澳台居住证识别
        /// </summary>
        [JsonProperty("IsSupportHMTResidentPermitOCR")]
        public bool? IsSupportHMTResidentPermitOCR{ get; set; }

        /// <summary>
        /// 用户语音回答过程中是否开启张嘴识别检测，默认不开启，仅在意愿核身问答模式中使用。
        /// </summary>
        [JsonProperty("MouthOpenRecognition")]
        public bool? MouthOpenRecognition{ get; set; }

        /// <summary>
        /// 意愿核身语音播报速度，配置后问答模式和点头模式的语音播报环节都会生效，默认值为0： 0：智能语速（根据播报文案的长度自动调整语音播报速度） 1：固定1倍速 2：固定1.2倍速 3：固定1.5倍速
        /// </summary>
        [JsonProperty("Speed")]
        public ulong? Speed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "UseIntentionVerify", this.UseIntentionVerify);
            this.SetParamSimple(map, prefix + "IntentionMode", this.IntentionMode);
            this.SetParamSimple(map, prefix + "IntentionVerifyText", this.IntentionVerifyText);
            this.SetParamArrayObj(map, prefix + "IntentionQuestions.", this.IntentionQuestions);
            this.SetParamArrayObj(map, prefix + "IntentionActions.", this.IntentionActions);
            this.SetParamSimple(map, prefix + "IntentionRecognition", this.IntentionRecognition);
            this.SetParamSimple(map, prefix + "IsSupportHMTResidentPermitOCR", this.IsSupportHMTResidentPermitOCR);
            this.SetParamSimple(map, prefix + "MouthOpenRecognition", this.MouthOpenRecognition);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
        }
    }
}

