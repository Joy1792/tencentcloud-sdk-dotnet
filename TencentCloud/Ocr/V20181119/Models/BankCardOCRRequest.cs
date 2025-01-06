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

    public class BankCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Base64 值。要求图片经Base64编码后不超过 7M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。要求图片经Base64编码后不超过 7M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。
        /// 建议图片存储于腾讯云，可保障更高的下载速度和稳定性。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 是否返回预处理（精确剪裁对齐）后的银行卡图片数据，默认false。
        /// </summary>
        [JsonProperty("RetBorderCutImage")]
        public bool? RetBorderCutImage{ get; set; }

        /// <summary>
        /// 是否返回卡号的切图图片数据，默认false。
        /// </summary>
        [JsonProperty("RetCardNoImage")]
        public bool? RetCardNoImage{ get; set; }

        /// <summary>
        /// 复印件检测开关，如果输入的图片是银行卡复印件图片则返回告警，默认false。
        /// </summary>
        [JsonProperty("EnableCopyCheck")]
        public bool? EnableCopyCheck{ get; set; }

        /// <summary>
        /// 翻拍检测开关，如果输入的图片是银行卡翻拍图片则返回告警，默认false。
        /// </summary>
        [JsonProperty("EnableReshootCheck")]
        public bool? EnableReshootCheck{ get; set; }

        /// <summary>
        /// 边框遮挡检测开关，如果输入的图片是银行卡边框被遮挡则返回告警，默认false。
        /// </summary>
        [JsonProperty("EnableBorderCheck")]
        public bool? EnableBorderCheck{ get; set; }

        /// <summary>
        /// 是否返回图片质量分数（图片质量分数是评价一个图片的模糊程度的标准），默认false。
        /// </summary>
        [JsonProperty("EnableQualityValue")]
        public bool? EnableQualityValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "RetBorderCutImage", this.RetBorderCutImage);
            this.SetParamSimple(map, prefix + "RetCardNoImage", this.RetCardNoImage);
            this.SetParamSimple(map, prefix + "EnableCopyCheck", this.EnableCopyCheck);
            this.SetParamSimple(map, prefix + "EnableReshootCheck", this.EnableReshootCheck);
            this.SetParamSimple(map, prefix + "EnableBorderCheck", this.EnableBorderCheck);
            this.SetParamSimple(map, prefix + "EnableQualityValue", this.EnableQualityValue);
        }
    }
}

