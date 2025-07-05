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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAIRecognitionTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频内容识别模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 视频内容识别模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 视频内容识别模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 人脸识别控制参数。
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfoForUpdate FaceConfigure{ get; set; }

        /// <summary>
        /// 文本全文识别控制参数。
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfoForUpdate OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// 文本关键词识别控制参数。
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfoForUpdate OcrWordsConfigure{ get; set; }

        /// <summary>
        /// 语音全文识别控制参数。
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfoForUpdate AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// 语音关键词识别控制参数。
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfoForUpdate AsrWordsConfigure{ get; set; }

        /// <summary>
        /// 语音翻译控制参数。
        /// </summary>
        [JsonProperty("TranslateConfigure")]
        public TranslateConfigureInfoForUpdate TranslateConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
            this.SetParamObj(map, prefix + "TranslateConfigure.", this.TranslateConfigure);
        }
    }
}

