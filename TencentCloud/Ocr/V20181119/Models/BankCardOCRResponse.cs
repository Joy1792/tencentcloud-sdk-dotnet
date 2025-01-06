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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BankCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 卡号
        /// </summary>
        [JsonProperty("CardNo")]
        public string CardNo{ get; set; }

        /// <summary>
        /// 银行信息
        /// </summary>
        [JsonProperty("BankInfo")]
        public string BankInfo{ get; set; }

        /// <summary>
        /// 有效期，格式如：07/2023
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// 卡名字
        /// </summary>
        [JsonProperty("CardName")]
        public string CardName{ get; set; }

        /// <summary>
        /// 切片图片数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BorderCutImage")]
        public string BorderCutImage{ get; set; }

        /// <summary>
        /// 卡号图片数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardNoImage")]
        public string CardNoImage{ get; set; }

        /// <summary>
        /// WarningCode 告警码列表和释义：
        /// -9110:银行卡日期无效; 
        /// -9111:银行卡边框不完整; 
        /// -9112:银行卡图片反光;
        /// -9113:银行卡复印件;
        /// -9114:银行卡翻拍件
        /// （告警码可以同时存在多个）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WarningCode")]
        public long?[] WarningCode{ get; set; }

        /// <summary>
        /// 图片质量分数，请求EnableQualityValue时返回（取值范围：0-100，分数越低越模糊，建议阈值≥50）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityValue")]
        public long? QualityValue{ get; set; }

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
            this.SetParamSimple(map, prefix + "CardNo", this.CardNo);
            this.SetParamSimple(map, prefix + "BankInfo", this.BankInfo);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "CardName", this.CardName);
            this.SetParamSimple(map, prefix + "BorderCutImage", this.BorderCutImage);
            this.SetParamSimple(map, prefix + "CardNoImage", this.CardNoImage);
            this.SetParamArraySimple(map, prefix + "WarningCode.", this.WarningCode);
            this.SetParamSimple(map, prefix + "QualityValue", this.QualityValue);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

