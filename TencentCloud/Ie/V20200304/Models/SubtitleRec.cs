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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleRec : AbstractModel
    {
        
        /// <summary>
        /// 语音识别：
        /// zh：中文
        /// en：英文
        /// </summary>
        [JsonProperty("AsrDst")]
        public string AsrDst{ get; set; }

        /// <summary>
        /// 翻译识别：
        /// zh：中文
        /// en：英文
        /// </summary>
        [JsonProperty("TransDst")]
        public string TransDst{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsrDst", this.AsrDst);
            this.SetParamSimple(map, prefix + "TransDst", this.TransDst);
        }
    }
}

