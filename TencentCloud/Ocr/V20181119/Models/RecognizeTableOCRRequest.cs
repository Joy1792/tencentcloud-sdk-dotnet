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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeTableOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片/PDF的 Base64 值。
        /// 要求图片/PDF经Base64编码后不超过 7M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片/PDF的 Url 地址。
        /// 要求图片/PDF经Base64编码后不超过 7M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。
        /// 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 是否开启PDF识别，默认值为false，开启后可同时支持图片和PDF的识别。
        /// </summary>
        [JsonProperty("IsPdf")]
        public bool? IsPdf{ get; set; }

        /// <summary>
        /// 需要识别的PDF页面的对应页码，仅支持PDF单页识别，当上传文件为PDF且IsPdf参数值为true时有效，默认值为1。
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// 语言，zh：中英文（默认）jap：日文
        /// </summary>
        [JsonProperty("TableLanguage")]
        public string TableLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "IsPdf", this.IsPdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "TableLanguage", this.TableLanguage);
        }
    }
}

