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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiRecognitionTaskAsrWordsResultOutput : AbstractModel
    {
        
        /// <summary>
        /// 语音关键词识别结果集。
        /// <font color=red>注意</font> ：该列表最多仅展示前 100 个元素。如希望获得完整结果，请从 ResultSetFileUrl 对应的文件中获取。
        /// </summary>
        [JsonProperty("ResultSet")]
        public AiRecognitionTaskAsrWordsResultItem[] ResultSet{ get; set; }

        /// <summary>
        /// 语音关键词识别结果集文件 URL。文件的内容为 JSON，数据结构与 ResultSet 字段一致。 （文件不会永久存储，到达ResultSetFileUrlExpireTime 时间点后文件将被删除）。
        /// </summary>
        [JsonProperty("ResultSetFileUrl")]
        public string ResultSetFileUrl{ get; set; }

        /// <summary>
        /// 语音关键词识别结果集文件 URL 失效时间，使用  [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("ResultSetFileUrlExpireTime")]
        public string ResultSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ResultSet.", this.ResultSet);
            this.SetParamSimple(map, prefix + "ResultSetFileUrl", this.ResultSetFileUrl);
            this.SetParamSimple(map, prefix + "ResultSetFileUrlExpireTime", this.ResultSetFileUrlExpireTime);
        }
    }
}

