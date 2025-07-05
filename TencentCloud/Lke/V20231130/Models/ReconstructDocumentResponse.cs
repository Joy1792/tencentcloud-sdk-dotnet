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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReconstructDocumentResponse : AbstractModel
    {
        
        /// <summary>
        /// 识别生成的Markdown文件base64编码的字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MarkdownBase64")]
        public string MarkdownBase64{ get; set; }

        /// <summary>
        /// 输入文件中嵌入的图片放在一个文件夹中打包为.zip压缩文件，识别生成的Markdown文件通过路径关联插入本文件夹中的图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InsetImagePackage")]
        public string InsetImagePackage{ get; set; }

        /// <summary>
        /// 输入文件中嵌入的图片中文字内容的识别结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocumentRecognizeInfo")]
        public DocumentRecognizeInfo[] DocumentRecognizeInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "MarkdownBase64", this.MarkdownBase64);
            this.SetParamSimple(map, prefix + "InsetImagePackage", this.InsetImagePackage);
            this.SetParamArrayObj(map, prefix + "DocumentRecognizeInfo.", this.DocumentRecognizeInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

